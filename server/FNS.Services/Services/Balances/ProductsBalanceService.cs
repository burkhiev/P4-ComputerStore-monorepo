using AutoMapper;
using FNS.Domain.Models.Balances;
using FNS.Domain.Models.Products;
using FNS.Domain.Repositories;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions.Balances;
using FNS.Services.Dtos.Balances;
using FNS.Services.Mappers.Balances;

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

        public OpResult<IEnumerable<ProductBalanceDto>> GetAll()
        {
            var balances = RootRepository.ProductBalances.GetAll();
            var dtos = Mapper.Map<IEnumerable<ProductBalanceDto>>(balances);

            var result = new OpResult<IEnumerable<ProductBalanceDto>>(dtos);
            return result;
        }

        public async Task<OpResult<ProductBalanceDto>> GetByIdAsync(string productBalanceId)
        {
            var balance = await RootRepository.ProductBalances.FindByIdAsync(productBalanceId);

            if(balance is null)
            {
                var notFoundResult = new NotFoundResult<ProductBalanceDto, ProductBalance>();
                return notFoundResult;
            }

            var dto = Mapper.Map<ProductBalanceDto>(balance);
            var result = new OpResult<ProductBalanceDto>(dto);

            return result;
        }

        public async Task<OpResult<IEnumerable<ProductBalanceDto>>> GetByProductIdAsync(string productId)
        {
            var product = await RootRepository.Products.FindByIdAsync(productId);

            if(product is null)
            {
                var notFoundResult = new NotFoundResult<IEnumerable<ProductBalanceDto>, Product>();
                return notFoundResult;
            }

            var balances = RootRepository.ProductBalances.FindByCondition(x => x.ProductId == productId);
            var dtos = Mapper.Map<IEnumerable<ProductBalanceDto>>(balances);

            var result = new OpResult<IEnumerable<ProductBalanceDto>>(dtos);
            return result;
        }
    }
}
