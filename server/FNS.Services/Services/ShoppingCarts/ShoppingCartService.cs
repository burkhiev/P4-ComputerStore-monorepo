using AutoMapper;
using FNS.Domain.Models.Products;
using FNS.Domain.Models.ShoppingCarts;
using FNS.Domain.Repositories;
using FNS.Domain.Utilities.OperationResults;
using FNS.Infrastructure.Configurations.ShoppingCarts;
using FNS.Services.Abstractions.ShoppingCarts;
using FNS.Services.Dtos;
using FNS.Services.Dtos.ShoppingCarts;
using FNS.Services.Mappers.ShoppingCarts;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace FNS.Services.Services.ShoppingCarts
{
    internal sealed class ShoppingCartService : IShoppingCartsService
    {
        private readonly IRootRepository _rootRepository;
        private readonly ShoppingCartMapperConfiguration _mapperConfig;

        public ShoppingCartService(IRootRepository rootRepository)
        {
            _rootRepository = rootRepository;
            _mapperConfig = new ShoppingCartMapperConfiguration();
        }

        private IRootRepository RootRepository => _rootRepository;

        private IMapper Mapper => _mapperConfig.Mapper;

        public AppOpResult<IEnumerable<ShoppingCartDto>> GetAll()
        {
            var shoppingCarts = RootRepository.ShoppingCarts.GetAll().ToArray();
            var dtos = Mapper.Map<IEnumerable<ShoppingCartDto>>(shoppingCarts);

            var result = new AppOpResult<IEnumerable<ShoppingCartDto>>(dtos);
            return result;
        }

        public async Task<AppOpResult<ShoppingCartWithAdditionalInfoDto>> GetByUserIdWithAdditionalInfoAsync(string userId)
        {
            var user = await RootRepository.Users.FindByIdAsync(userId);

            if(user is null)
            {
                var errResult = new NotFoundShoppingCartByUserIdResult<ShoppingCartWithAdditionalInfoDto>();
                return errResult;
            }

            await RootRepository.Users.LoadReferencesAsync(user, u => u.ShoppingCart);

            if(user.ShoppingCart is null)
            {
                var errResult = new NotFoundShoppingCartByUserIdResult<ShoppingCartWithAdditionalInfoDto>();
                return errResult;
            }

            await RootRepository.ShoppingCarts.LoadShoppingCartsWithItemsAndProducts(user.ShoppingCart);

            var dto = Mapper.Map<ShoppingCartWithAdditionalInfoDto>(user.ShoppingCart);
            var result = new AppOpResult<ShoppingCartWithAdditionalInfoDto>(dto);

            return result;
        }

        public async Task<AppOpResult<EmptyDto>> AddProductAsync(string userId, string productId)
        {
            var cart = RootRepository.ShoppingCarts.FindByCondition(x => x.UserId == userId).FirstOrDefault();

            if(cart is null)
            {
                var fault = new NotFoundShoppingCartByUserIdResult<EmptyDto>();
                return fault;
            }


            var product = await RootRepository.Products.FindByIdAsync(productId);

            if(product is null)
            {
                var fault = new NotFoundProductResult<EmptyDto>();
                return fault;
            }


            var newCartItem = new ShoppingCartItem
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = productId,
                Amount = 1,
                ShoppingCartId = cart.Id,
            };

            await RootRepository.ShoppingCartItems.AddAsync(newCartItem);


            try
            {
                await RootRepository.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException ex)
            {
                var fault = new InvalidDbConcurrencyUpdateOpResult<EmptyDto>();
                return fault;
            }
            catch(DbUpdateException ex)
            {
                var fault = new InvalidDbConcurrencyUpdateOpResult<EmptyDto>();
                return fault;
            }


            var result = new AppOpResult<EmptyDto>();
            return result;
        }

        public async Task<AppOpResult<ShoppingCartForChangeItemAmountDto>> UpdateItemAmountAsync(string userId, string cartItemId, int newAmount)
        {
            // проверка Id пользователя
            var user = await RootRepository.Users.FindByIdAsync(userId);

            if(user is null)
            {
                var fault = new NotFoundShoppingCartByUserIdResult<ShoppingCartForChangeItemAmountDto>();
                return fault;
            }


            // проверка Id позиции в корзине
            var cartItem = await RootRepository.ShoppingCartItems.FindByIdAsync(cartItemId);

            if(cartItem is null)
            {
                var fault = new NotFoundShoppingCartItemResult<ShoppingCartForChangeItemAmountDto>();
                return fault;
            }


            // проверка количества
            cartItem.Amount = newAmount;

            if(cartItem.Amount < ShoppingCartItemsConfiguration.MinShoppingCartAmountValue
               || ShoppingCartItemsConfiguration.MaxShoppingCartAmountValue < cartItem.Amount)
            {
                var fault = new ItemAmountOutOfRangeResult<ShoppingCartForChangeItemAmountDto>();
                return fault;
            }


            RootRepository.ShoppingCartItems.Update(cartItem);


            try
            {
                await RootRepository.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException ex)
            {
                var fault = new InvalidDbConcurrencyUpdateOpResult<ShoppingCartForChangeItemAmountDto>();
                return fault;
            }
            catch(DbUpdateException ex)
            {
                var fault = new InvalidDbConcurrencyUpdateOpResult<ShoppingCartForChangeItemAmountDto>();
                return fault;
            }


            var amountDto = new ShoppingCartForChangeItemAmountDto
            { 
                ItemId = cartItem.Id,
                ConcurrencyToken = cartItem.xmin,
                Amount = cartItem.Amount 
            };

            var result = new AppOpResult<ShoppingCartForChangeItemAmountDto>(amountDto);
            return result;
        }

        public async Task<AppOpResult<EmptyDto>> DeleteItemAsync(string userId, string cartItemId)
        {
            var user = await RootRepository.Users.FindByIdAsync(userId);

            if(user is null)
            {
                var fault = new NotFoundShoppingCartByUserIdResult<EmptyDto>();
                return fault;
            }


            var cartItem = await RootRepository.ShoppingCartItems.FindByIdAsync(cartItemId);

            if(cartItem is not null)
            {
                RootRepository.ShoppingCartItems.Remove(cartItem);

                try
                {
                    await RootRepository.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException ex)
                {
                    var fault = new InvalidDbConcurrencyUpdateOpResult<EmptyDto>();
                    return fault;
                }
                catch(DbUpdateException ex)
                {
                    var fault = new InvalidDbUpdateOpResult<EmptyDto>();
                    return fault;
                }
            }


            var result = new AppOpResult<EmptyDto>();
            return result;
        }

        private sealed class NotFoundShoppingCartByUserIdResult<T> : AppOpResult<T>
        {
            public NotFoundShoppingCartByUserIdResult()
            {
                FaultResult = new AppProblemDetails
                {
                    Title = "ShoppingCart not found",
                    Detail = $"ShoppingCart with specified userId is not found.",
                    StatusCode = StatusCodes.Status404NotFound,
                };
            }
        }

        private sealed class ItemAmountOutOfRangeResult<T> : AppOpResult<T>
        {
            public ItemAmountOutOfRangeResult()
            {
                FaultResult = new AppProblemDetails
                {
                    Title = $"{nameof(ShoppingCartItem)} entity has invalid property",
                    Detail = $"{nameof(ShoppingCartItem)}.Amount property is out of range.",
                    StatusCode = StatusCodes.Status400BadRequest,
                };
            }
        }

        private sealed class NotFoundProductResult<T> : AppOpResult<T>
        {
            public NotFoundProductResult()
            {
                FaultResult = new AppProblemDetails
                {
                    Title = $"{nameof(Product)} not found",
                    Detail = $"{nameof(ShoppingCartItem)} isn't added because invalid {nameof(Product)} Id received.",
                    StatusCode = StatusCodes.Status404NotFound,
                };
            }
        }

        private sealed class NotFoundShoppingCartItemResult<T> : AppOpResult<T>
        {
            public NotFoundShoppingCartItemResult()
            {
                FaultResult = new AppProblemDetails
                {
                    Title = $"{nameof(ShoppingCartItem)} not found",
                    Detail = $"{nameof(ShoppingCartItem)} with specified Id is not found.",
                    StatusCode = StatusCodes.Status404NotFound,
                };
            }
        }
    }
}
