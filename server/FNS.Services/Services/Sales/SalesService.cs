using AutoMapper;
using FNS.Domain.Exceptions;
using FNS.Domain.Models.Identity;
using FNS.Domain.Models.SalesReceipts;
using FNS.Domain.Models.ShoppingCarts;
using FNS.Domain.Repositories;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions.SalesReceipts;
using FNS.Services.Dtos;
using FNS.Services.Dtos.SalesReceipts;
using FNS.Services.Mappers.SalesReceipts;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NodaTime;

namespace FNS.Services.Services.Sales
{
    internal sealed class SalesService : ISalesService
    {
        private readonly IRootRepository _rootRepository;
        private readonly IMapper _mapper;

        public SalesService(IRootRepository rootRepository)
        {
            _rootRepository = rootRepository;
            _mapper = new SalesReceiptsMapperConfiguration().Mapper;
        }

        public IRootRepository RootRepository => _rootRepository;

        public IMapper Mapper => _mapper;

        public OpResult<IEnumerable<SalesReceiptDto>> GetAll()
        {
            var receiptes = RootRepository.SalesReceipts.GetAll().ToArray();
            var dtos = Mapper.Map<IEnumerable<SalesReceiptDto>>(receiptes);

            var result = new OpResult<IEnumerable<SalesReceiptDto>>(dtos);
            return result;
        }

        public async Task<OpResult<SalesReceiptWithAdditionalInfoDto>> GetWithAdditionalInfoAsync(string id)
        {
            var receipt = await RootRepository.SalesReceipts.FindByIdAsync(id);

            if(receipt is null)
            {
                var errResult = new NotFoundResult<SalesReceiptWithAdditionalInfoDto, SalesReceipt>();
                return errResult;
            }

            await RootRepository.SalesReceiptWithProducts.LoadAdditionalInfoBySalesReceiptId(receipt.Id);

            var dtos = Mapper.Map<SalesReceiptWithAdditionalInfoDto>(receipt);
            var result = new OpResult<SalesReceiptWithAdditionalInfoDto>(dtos);

            return result;
        }

        public async Task<OpResult<IEnumerable<SalesReceiptWithAdditionalInfoDto>>> GetByUserIdAsync(string userId)
        {
            var user = await RootRepository.Users.FindByIdAsync(userId);

            if(user is null)
            {
                var badResult = new NotFoundResult<IEnumerable<SalesReceiptWithAdditionalInfoDto>, User>();
                return badResult;
            }

            await RootRepository.SalesReceiptWithProducts.LoadAdditionalInfoByUserId(user.Id);
            var salesReceipts = await RootRepository.SalesReceipts.FindByCondition(x => x.UserId == user.Id).ToListAsync();

            var dtos = Mapper.Map<IEnumerable<SalesReceiptWithAdditionalInfoDto>>(salesReceipts);
            var result = new OpResult<IEnumerable<SalesReceiptWithAdditionalInfoDto>>(dtos);

            return result;
        }

        public async Task<OpResult<SaleSuccessResultDto>> MakeSaleAsync(string userId)
        {
            // проверяем наличие пользователя
            var user = await RootRepository.Users.FindByIdAsync(userId);

            if(user is null)
            {
                var notFoundResult = new NotFoundResult<SaleSuccessResultDto, User>();
                return notFoundResult;
            }


            // ищем его корзину
            var cart = RootRepository.ShoppingCarts.FindByCondition(x => x.UserId == user.Id).FirstOrDefault();

            if(cart is null)
            {
                var notFoundResult = new NotFoundResult<SaleSuccessResultDto, ShoppingCart>();
                return notFoundResult;
            }


            // переносим товары из корзины в чек
            cart.ShoppingCartItems = new List<ShoppingCartItem>();
            await RootRepository.ShoppingCarts.LoadShoppingCartsWithItemsAndProducts(cart);

            var salesReceipt = new SalesReceipt
            {
                Id = Guid.NewGuid().ToString(),
                UserId = user.Id,
            };
            await RootRepository.SalesReceipts.AddAsync(salesReceipt);


            bool notEnoughProductsInStock = false;

            foreach(var cartItem in cart.ShoppingCartItems)
            {
                // сначала проверяем остатки товара
                var balances = RootRepository.ProductBalances.FindByCondition(x => x.ProductId == cartItem.ProductId).ToArray();

                if(balances.Length != 1)
                {
                    throw new UnknownException();
                }

                var prodBalance = balances[0];

                if(cartItem.Amount > prodBalance.Amount)
                {
                    notEnoughProductsInStock = true;
                    break;
                }

                // затем вычитаем из остатков
                prodBalance.Amount -= cartItem.Amount;
                RootRepository.ProductBalances.Update(prodBalance);

                // и добавляем в чек
                await RootRepository.SalesReceiptWithProducts.AddAsync(new SalesReceiptWithProduct
                { 
                    Id = Guid.NewGuid().ToString(),
                    SalesReceiptId = salesReceipt.Id,
                    ProductId = cartItem.ProductId,
                    Amount = cartItem.Amount,
                });
            }

            if(notEnoughProductsInStock)
            {
                var fault = new SaleFailedBecauseNotEnoughAmountForSomeProductOpResult();
                return fault;
            }


            // после очищаем корзину
            RootRepository.ShoppingCartItems.RemoveMany(cart.ShoppingCartItems);


            try
            {
                await RootRepository.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException ex)
            {
                var fault = new InvalidDbConcurrencyUpdateResult<SaleSuccessResultDto>();
                return fault;
            }
            catch(DbUpdateException ex)
            {
                var fault = new InvalidDbConcurrencyUpdateResult<SaleSuccessResultDto>();
                return fault;
            }


            var sucResDto = new SaleSuccessResultDto
            {
                UserId = user.Id,
                DateOfSale = Instant.FromDateTimeUtc(DateTime.UtcNow),
            };

            var result = new OpResult<SaleSuccessResultDto>(sucResDto);
            return result;
        }

        private sealed class SaleFailedBecauseNotEnoughAmountForSomeProductOpResult : OpResult<SaleSuccessResultDto>
        {
            public SaleFailedBecauseNotEnoughAmountForSomeProductOpResult() : base()
            {
                FailResult = new ProblemResultInfo
                {
                    Title = "Sale is not completed",
                    Detail = "Sale is not completed because not enough amount for some product in stock.",
                    StatusCode = StatusCodes.Status400BadRequest,
                };
            }
        }
    }
}
