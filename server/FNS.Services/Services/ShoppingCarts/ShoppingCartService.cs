using System.Reflection;
using AutoMapper;
using FNS.ContextsInfrastructure.Repositories;
using FNS.Domain.Exceptions;
using FNS.Domain.Models.Identity;
using FNS.Domain.Models.Products;
using FNS.Domain.Models.ShoppingCarts;
using FNS.Domain.Repositories;
using FNS.Domain.Utilities.OperationResults;
using FNS.Infrastructure.Configurations.ShoppingCarts;
using FNS.Services.Abstractions.ShoppingCarts;
using FNS.Services.Dtos;
using FNS.Services.Dtos.Purchases;
using FNS.Services.Dtos.ShoppingCarts;
using FNS.Services.Mappers.ShoppingCarts;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace FNS.Services.Services.ShoppingCarts
{
    /// <summary>
    /// Класс сервиса, отвечающего за работу с корзиной покупателя
    /// </summary>
    internal sealed class ShoppingCartService : IShoppingCartsService
    {
        // Макс. кол-во позиций в корзине
        public const int MaxInCartItemsCount = 20;

        // Макс. кол-во позиций в корзине во всех корзинах вместе
        public const int CartItemsTotalLimit = 1000;

        // Удаляемое кол-во позиций в корзине
        public const int CountOfDeletingCarts = 200;

        private readonly IRootRepository _rootRepository;
        private readonly ShoppingCartMapperConfiguration _mapperConfig;

        public ShoppingCartService(IRootRepository rootRepository)
        {
            _rootRepository = rootRepository;
            _mapperConfig = new ShoppingCartMapperConfiguration();
        }

        private IRootRepository RootRepo => _rootRepository;

        private IMapper Mapper => _mapperConfig.Mapper;

        public OpResult<IEnumerable<ShoppingCartDto>> GetAll()
        {
            var shoppingCarts = RootRepo.ShoppingCarts.GetAll().ToArray();
            var dtos = Mapper.Map<IEnumerable<ShoppingCartDto>>(shoppingCarts);

            var result = new OpResult<IEnumerable<ShoppingCartDto>>(dtos);
            return result;
        }

        public async Task<OpResult<ShoppingCartWithAdditionalInfoDto>> GetByUserIdWithAdditionalInfoAsync(string userId)
        {
            var user = await RootRepo.Users.FindByIdAsync(userId);

            if(user is null)
            {
                var notFound = new NotFoundResult<ShoppingCartWithAdditionalInfoDto, User>();
                return notFound;
            }

            await RootRepo.Users.LoadReferencesAsync(user, u => u.ShoppingCart);

            if(user.ShoppingCart is null)
            {
                var notFound = new NotFoundResult<ShoppingCartWithAdditionalInfoDto, ShoppingCart>();
                return notFound;
            }

            await RootRepo.ShoppingCarts.LoadShoppingCartsWithItemsAndProducts(user.ShoppingCart);

            var dto = Mapper.Map<ShoppingCartWithAdditionalInfoDto>(user.ShoppingCart);
            var result = new OpResult<ShoppingCartWithAdditionalInfoDto>(dto);

            return result;
        }

        public async Task<OpResult<ShoppingCartItemDto>> AddProductAsync(string userId, string productId)
        {
            var user = await RootRepo.Users.FindByIdAsync(userId);

            if(user is null)
            {
                var notFound = new NotFoundResult<ShoppingCartItemDto, User>();
                return notFound;
            }


            await RootRepo.Users.LoadReferencesAsync(user, u => u.ShoppingCart);
            ShoppingCart cart = user.ShoppingCart;

            var allCartItems = RootRepo.ShoppingCartItems.GetAll();
            var cartItems = allCartItems.Where(x => x.ShoppingCartId == cart.Id);

            // есть ли место приходной накладной?
            if(cartItems.Count() >= MaxInCartItemsCount)
            {
                var tooMany = new TooManyRecordsReceivedResult<ShoppingCartItemDto>(MaxInCartItemsCount);
                return tooMany;
            }


            // удаляем старые записи для предотвращения переполнения БД
            // Здесь мы смотрим за количеством товара во всех корзинах,
            // т.к. корзин ровно столько сколько и пользователей
            if(allCartItems.Count() > CartItemsTotalLimit)
            {
                var deletingCarts = RootRepo.ShoppingCartItems.GetAll()
                    .OrderByDescending(x => x.CreatedAt)
                    .Take(CountOfDeletingCarts)
                    .ToList();

                RootRepo.ShoppingCartItems.RemoveMany(deletingCarts);
                await RootRepo.SaveChangesAsync();
            }


            var newCartItem = new ShoppingCartItem
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = productId,
                Amount = 1,
                ShoppingCartId = cart.Id,
            };

            await RootRepo.ShoppingCartItems.AddAsync(newCartItem);


            try
            {
                await RootRepo.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException ex)
            {
                var fault = new InvalidDbConcurrencyUpdateResult<ShoppingCartItemDto>();
                return fault;
            }
            catch(DbUpdateException ex)
            {
                var fault = new InvalidDbConcurrencyUpdateResult<ShoppingCartItemDto>();
                return fault;
            }


            var newCartItemDto = Mapper.Map<ShoppingCartItemDto>(newCartItem);
            var result = new OpResult<ShoppingCartItemDto>();

            return result;
        }

        public async Task<OpResult<ShoppingCartForChangeItemAmountDto>> UpdateItemAmountAsync(ShoppingCartForChangeItemAmountDto dto)
        {
            // проверка Id пользователя
            var user = await RootRepo.Users
                .FindByCondition(x => x.Id == dto.UserId)
                .FirstOrDefaultAsync();

            if(user is null)
            {
                var notFound = new NotFoundResult<ShoppingCartForChangeItemAmountDto, User>();
                return notFound;
            }


            // проверка Id позиции в корзине
            var cartItem = await RootRepo.ShoppingCartItems
                .FindByCondition(x => x.Id == dto.ItemId && x.xmin == dto.ConcurrencyToken)
                .FirstOrDefaultAsync();

            if(cartItem is null)
            {
                var notFound = new NotFoundResult<ShoppingCartForChangeItemAmountDto, ShoppingCartItem>();
                return notFound;
            }


            // проверка количества
            if(dto.Amount < ShoppingCartItemsConfiguration.MinShoppingCartAmountValue
               || ShoppingCartItemsConfiguration.MaxShoppingCartAmountValue < dto.Amount)
            {
                var outOfRange = new ItemAmountOutOfRangeResult<ShoppingCartForChangeItemAmountDto>();
                return outOfRange;
            }


            cartItem.Amount = dto.Amount;
            RootRepo.ShoppingCartItems.Update(cartItem);


            try
            {
                await RootRepo.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException ex)
            {
                var fault = new InvalidDbConcurrencyUpdateResult<ShoppingCartForChangeItemAmountDto>();
                return fault;
            }
            catch(DbUpdateException ex)
            {
                var fault = new InvalidDbConcurrencyUpdateResult<ShoppingCartForChangeItemAmountDto>();
                return fault;
            }


            var amountDto = new ShoppingCartForChangeItemAmountDto
            { 
                ItemId = cartItem.Id,
                ConcurrencyToken = cartItem.xmin,
                Amount = cartItem.Amount 
            };

            var result = new OpResult<ShoppingCartForChangeItemAmountDto>(amountDto);
            return result;
        }

        public async Task<OpResult<EmptyDto>> DeleteItemAsync(string userId, string cartItemId)
        {
            var user = await RootRepo.Users.FindByIdAsync(userId);

            if(user is null)
            {
                var notFound = new NotFoundResult<EmptyDto, User>();
                return notFound;
            }


            var cartItem = await RootRepo.ShoppingCartItems.FindByIdAsync(cartItemId);

            if(cartItem is not null)
            {
                RootRepo.ShoppingCartItems.Remove(cartItem);

                try
                {
                    await RootRepo.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException ex)
                {
                    var fault = new InvalidDbConcurrencyUpdateResult<EmptyDto>();
                    return fault;
                }
                catch(DbUpdateException ex)
                {
                    var fault = new InvalidDbUpdateResult<EmptyDto>();
                    return fault;
                }
            }


            var result = new OpResult<EmptyDto>();
            return result;
        }

        private sealed class ItemAmountOutOfRangeResult<T> : OpResult<T>
        {
            public ItemAmountOutOfRangeResult()
            {
                FailResult = new ProblemResultInfo
                {
                    Title = $"{nameof(ShoppingCartItem)} entity has invalid property",
                    Detail = $"{nameof(ShoppingCartItem)}.Amount property is out of range.",
                    StatusCode = StatusCodes.Status400BadRequest,
                };
            }
        }
    }
}
