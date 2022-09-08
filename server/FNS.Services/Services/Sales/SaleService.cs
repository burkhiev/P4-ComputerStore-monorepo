using AutoMapper;
using FNS.Domain.Exceptions;
using FNS.Domain.Models.SalesReceipts;
using FNS.Domain.Models.ShoppingCarts;
using FNS.Domain.Repositories;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions.SalesReceipts;
using FNS.Services.Dtos.SalesReceipts;
using FNS.Services.Mappers.SalesReceipts;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NodaTime;

namespace FNS.Services.Services.Sales
{
    internal sealed class SaleService : ISalesReceiptsService
    {
        private readonly IRootRepository _rootRepository;
        private readonly IMapper _mapper;

        public SaleService(IRootRepository rootRepository)
        {
            _rootRepository = rootRepository;
            _mapper = new SalesReceiptsMapperConfiguration().Mapper;
        }

        public IRootRepository RootRepository => _rootRepository;

        public IMapper Mapper => _mapper;

        public AppOpResult<IEnumerable<SalesReceiptDto>> GetAll()
        {
            var receiptes = RootRepository.SalesReceipts.GetAll().ToArray();
            var dtos = Mapper.Map<IEnumerable<SalesReceiptDto>>(receiptes);

            var result = new AppOpResult<IEnumerable<SalesReceiptDto>>(dtos);
            return result;
        }

        public async Task<AppOpResult<SalesReceiptWithAdditionalInfoDto>> GetWithAdditionalInfoAsync(string id)
        {
            var receipt = await RootRepository.SalesReceipts.FindByIdAsync(id);

            if(receipt is null)
            {
                var errResult = new SalesReceiptNotFoundResult();
                return errResult;
            }

            await RootRepository.SalesReceiptWithProducts.LoadAdditionalInfoBySalesReceiptId(receipt.Id);

            var dtos = Mapper.Map<SalesReceiptWithAdditionalInfoDto>(receipt);
            var result = new AppOpResult<SalesReceiptWithAdditionalInfoDto>(dtos);

            return result;
        }

        public async Task<AppOpResult<IEnumerable<SalesReceiptWithAdditionalInfoDto>>> GetByUserIdAsync(string userId)
        {
            var user = await RootRepository.Users.FindByIdAsync(userId);

            if(user is null)
            {
                var badResult = new EntityNotFoundOpResult<IEnumerable<SalesReceiptWithAdditionalInfoDto>>();
                return badResult;
            }

            await RootRepository.SalesReceiptWithProducts.LoadAdditionalInfoByUserId(user.Id);
            var salesReceipts = await RootRepository.SalesReceipts.FindByCondition(x => x.UserId == user.Id).ToListAsync();

            var dtos = Mapper.Map<IEnumerable<SalesReceiptWithAdditionalInfoDto>>(salesReceipts);
            var result = new AppOpResult<IEnumerable<SalesReceiptWithAdditionalInfoDto>>(dtos);

            return result;
        }

        public async Task<AppOpResult<SaleSuccessResultDto>> MakeSaleAsync(SaleDto saleInfo)
        {
            // проверяем наличие пользователя
            var user = await RootRepository.Users.FindByIdAsync(saleInfo.UserId);

            if(user is null)
            {
                var fault = new SaleFailedBecauseUserNotFoundOpResult();
                return fault;
            }


            // ищем корзину
            var cart = RootRepository.ShoppingCarts.FindByCondition(x => x.UserId == user.Id).FirstOrDefault();

            if(cart is null)
            {
                var fault = new SaleFailedBecauseShoppingCartNotFoundResult();
                return fault;
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
                // проверяем остатки товара
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

                // вычет из остатков
                prodBalance.Amount -= cartItem.Amount;
                RootRepository.ProductBalances.Update(prodBalance);

                // добавление в чек
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


            // очистка корзины
            RootRepository.ShoppingCartItems.RemoveMany(cart.ShoppingCartItems);


            try
            {
                await RootRepository.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException ex)
            {
                var fault = new InvalidDbConcurrencyUpdateOpResult<SaleSuccessResultDto>();
                return fault;
            }
            catch(DbUpdateException ex)
            {
                var fault = new InvalidDbConcurrencyUpdateOpResult<SaleSuccessResultDto>();
                return fault;
            }


            var sucResDto = new SaleSuccessResultDto
            {
                UserId = user.Id,
                DateOfSale = Instant.FromDateTimeUtc(DateTime.UtcNow),
            };

            var result = new AppOpResult<SaleSuccessResultDto>(sucResDto);
            return result;
        }

        private sealed class SalesReceiptNotFoundResult : AppOpResult<SalesReceiptWithAdditionalInfoDto>
        {
            public SalesReceiptNotFoundResult()
            {
                FaultResult = new AppProblemDetails
                {
                    Title = $"{typeof(SalesReceipt).Name} not found",
                    Detail = $"{typeof(SalesReceipt).Name} with specified Id is not found",
                    StatusCode = StatusCodes.Status404NotFound,
                };
            }
        }

        private sealed class SaleFailedBecauseUserNotFoundOpResult : AppOpResult<SaleSuccessResultDto>
        {
            public SaleFailedBecauseUserNotFoundOpResult() : base()
            {
                FaultResult = new AppProblemDetails
                {
                    Title = "Sale is not completed",
                    Detail = "Sale is not completed because there is no user with specified id.",
                    StatusCode = StatusCodes.Status404NotFound,
                };
            }
        }

        private sealed class SaleFailedBecauseShoppingCartNotFoundResult : AppOpResult<SaleSuccessResultDto>
        {
            public SaleFailedBecauseShoppingCartNotFoundResult() : base()
            {
                FaultResult = new AppProblemDetails
                {
                    Title = "Sale is not completed",
                    Detail = "Sale is not completed because there is no shopping cart for specified user.",
                    StatusCode = StatusCodes.Status404NotFound,
                };
            }
        }

        private sealed class SaleFailedBecauseNotEnoughAmountForSomeProductOpResult : AppOpResult<SaleSuccessResultDto>
        {
            public SaleFailedBecauseNotEnoughAmountForSomeProductOpResult() : base()
            {
                FaultResult = new AppProblemDetails
                {
                    Title = "Sale is not completed",
                    Detail = "Sale is not completed because not enough amount for some product in stock.",
                    StatusCode = StatusCodes.Status400BadRequest,
                };
            }
        }
    }
}
