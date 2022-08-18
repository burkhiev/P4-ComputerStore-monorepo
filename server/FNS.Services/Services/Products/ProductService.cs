using AutoMapper;
using FNS.Domain.Repositories;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions.Products;
using FNS.Services.Dtos.Products;
using FNS.Services.Mappers.Products;

namespace FNS.Services.Services.Products
{
    public sealed class ProductService : IProductsService
    {
        private readonly IRootRepository _rootRepository;
        private readonly IMapper _mapper;

        public ProductService(IRootRepository rootRepository)
        {
            _rootRepository = rootRepository;
            _mapper = ProductMapperService.Mapper;
        }

        private IRootRepository RootRepository => _rootRepository;

        public AppOperationResult<IEnumerable<ProductDto>> GetProductsDtos()
        {
            var products = RootRepository.ProductRepositoryManager.ProductRepository.GetAll();
            var productsDtos = _mapper.ProjectTo<ProductDto>(products);

            var result = new AppOperationResult<IEnumerable<ProductDto>>(productsDtos);
            return result;
        }

        public async Task<AppOperationResult<ProductAdditionalInfoDto>> GetProductAdditionalInfoAsync(Guid id, CancellationToken ct = default)
        {
            var product = await RootRepository.ProductRepositoryManager.ProductRepository.FindAsync(id, ct);
            var additionalInfo = _mapper.Map<ProductAdditionalInfoDto>(product);

            var result = new AppOperationResult<ProductAdditionalInfoDto>(additionalInfo);
            return result;
        }
    }
}
