using AutoMapper;
using FNS.Domain.Exceptions;
using FNS.Domain.Models.SalesReceipts;
using FNS.Domain.Repositories;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions.SalesReceipts;
using FNS.Services.Dtos.SalesReceipts;
using FNS.Services.Mappers.SalesReceipts;
using Microsoft.AspNetCore.Http;
using NodaTime;

namespace FNS.Services.Services.Sales
{
    internal sealed class SaleService : ISalesReceiptService
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
            var receiptes = RootRepository.SalesReceiptRepository.GetAll().ToArray();
            var dtos = Mapper.Map<IEnumerable<SalesReceiptDto>>(receiptes);

            var result = new AppOpResult<IEnumerable<SalesReceiptDto>>(dtos);
            return result;
        }

        public async Task<AppOpResult<SalesReceiptWithAdditionalInfoDto>> GetWithAdditionalAsync(string id, CancellationToken ct = default)
        {
            var receipt = await RootRepository.SalesReceiptRepository.FindByIdAsync(id, ct);

            if(receipt is null)
            {
                var errResult = new SalesReceiptNotFoundResult();
                return errResult;
            }

            await RootRepository.SalesReceiptWithProductRepository.LoadAdditionalInfoBySalesReceiptId(receipt.Id, ct);

            var dtos = Mapper.Map<SalesReceiptWithAdditionalInfoDto>(receipt);
            var result = new AppOpResult<SalesReceiptWithAdditionalInfoDto>(dtos);

            return result;
        }

        public async Task<AppOpResult<SaleSuccessResultDto>> MakeSaleAsync(SaleDto saleInfo)
        {
            // проверяем наличие пользователя
            var user = await RootRepository.UsersRepository.FindByIdAsync(saleInfo.UserId);

            if(user is null)
            {
                var fault = new SaleFailedBecauseUserNotFoundOpResult();
                return fault;
            }


            bool someProductIsNotFound = false;
            bool notEnoughProductsInStock = false;

            foreach(var prodSaleInfo in saleInfo.ProductsInfo)
            {
                // проверяем, существует ли товар с указанным ID
                var product = await RootRepository.ProductRepository.FindByIdAsync(prodSaleInfo.Id);

                if(product is null)
                {
                    someProductIsNotFound = true;
                    break;
                }

                // проверяем, если ли запись для учета остатков товара
                var balances = RootRepository.ProductBalanceRepository.FindByCondition(x => x.ProductId == product.Id).ToArray();

                if(balances.Length != 1)
                {
                    throw new UnknownException();
                }

                var prodBalance = balances[0];

                // по найденной учетной записи сверяем остатки и кол-во продаваемого товара
                if(prodSaleInfo.Amount > prodBalance.Amount)
                {
                    notEnoughProductsInStock = true;
                    break;
                }

                // вычет
                prodBalance.Amount -= prodSaleInfo.Amount;
                RootRepository.ProductBalanceRepository.Update(prodBalance);
            }

            if(someProductIsNotFound)
            {
                var fault = new SaleFailedBecauseSomeProductNotFoundOpResult();
                return fault;
            }

            if(notEnoughProductsInStock)
            {
                var fault = new SaleFailedBecauseNotEnoughAmountForSomeProductOpResult();
                return fault;
            }


            int changedRecords = await RootRepository.SaveChangesAsync();

            if(changedRecords != saleInfo.ProductsInfo.Count)
            {
                throw new UnknownException();
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

        private sealed class SaleFailedBecauseSomeProductNotFoundOpResult : AppOpResult<SaleSuccessResultDto>
        {
            public SaleFailedBecauseSomeProductNotFoundOpResult() : base()
            {
                FaultResult = new AppProblemDetails
                {
                    Title = "Sale is not completed",
                    Detail = "Sale is not completed because cannot find some products in the shopping cart.",
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
