using AutoMapper;
using FNS.Domain.Models.Balances;
using FNS.Domain.Models.Products;
using FNS.Domain.Repositories;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions.Balances;
using FNS.Services.Dtos.Balances;
using FNS.Services.Mappers.Balances;
using Microsoft.AspNetCore.Http;

namespace FNS.Services.Services.Balances
{
    internal sealed class ProductsBalanceService : IProductsBalanceService
    {
        private readonly IRootRepository _rootRepository;
        private readonly IMapper _mapper;

        public ProductsBalanceService(IRootRepository rootRepository)
        {
            _rootRepository = rootRepository;
            _mapper = new ProductBalanceMapperConfiguration().Mapper;
        }

        public IRootRepository RootRepository => _rootRepository;

        public IMapper Mapper => _mapper;

        public AppOpResult<IEnumerable<ProductBalanceDto>> GetAll()
        {
            var balances = RootRepository.ProductBalanceRepository.GetAll();
            var dtos = Mapper.Map<IEnumerable<ProductBalanceDto>>(balances);

            var result = new AppOpResult<IEnumerable<ProductBalanceDto>>(dtos);
            return result;
        }

        public async Task<AppOpResult<ProductBalanceDto>> GetByIdAsync(string productBalanceId)
        {
            var balance = await RootRepository.ProductBalanceRepository.FindByIdAsync(productBalanceId);

            if(balance is null)
            {
                var faultResult = new ProductBalanceNotFoundResult();
                return faultResult;
            }

            var dto = Mapper.Map<ProductBalanceDto>(balance);
            var result = new AppOpResult<ProductBalanceDto>(dto);

            return result;
        }

        public async Task<AppOpResult<IEnumerable<ProductBalanceDto>>> GetByProductIdAsync(string productId)
        {
            var product = await RootRepository.ProductRepository.FindByIdAsync(productId);

            if(product is null)
            {
                var faultResult = new ProductNotFoundByProductResult();
                return faultResult;
            }

            var balances = RootRepository.ProductBalanceRepository.FindByCondition(x => x.ProductId == productId);
            var dtos = Mapper.Map<IEnumerable<ProductBalanceDto>>(balances);

            var result = new AppOpResult<IEnumerable<ProductBalanceDto>>(dtos);
            return result;
        }

        private sealed class ProductBalanceNotFoundResult : AppOpResult<ProductBalanceDto>
        {
            public ProductBalanceNotFoundResult() : base()
            {
                FaultResult = new AppProblemDetails()
                {
                    Title = $"{nameof(ProductBalance)} not found",
                    Detail = $"{nameof(ProductBalance)} with specified Id is not found.",
                    StatusCode = StatusCodes.Status404NotFound,
                };
            }
        }

        private sealed class ProductNotFoundByProductResult : AppOpResult<IEnumerable<ProductBalanceDto>>
        {
            public ProductNotFoundByProductResult() : base()
            {
                FaultResult = new AppProblemDetails
                {
                    Title = $"{nameof(ProductBalance)} not found",
                    Detail = $"{nameof(ProductBalance)} entities for specified {nameof(Product)} Id is not found.",
                    StatusCode = StatusCodes.Status404NotFound,
                };
            }
        }
    }
}
