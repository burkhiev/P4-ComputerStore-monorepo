using AutoMapper;
using FNS.Domain.Models.Products;
using FNS.Domain.Repositories;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions.Products;
using FNS.Services.Dtos.Products;
using FNS.Services.Mappers.Products;
using Microsoft.AspNetCore.Http;

namespace FNS.Services.Services.Products
{
    internal sealed class ProductService : IProductsService
    {
        private readonly IRootRepository _rootRepository;
        private readonly ProductMapperConfiguration _mapperConfig;

        public ProductService(IRootRepository rootRepository)
        {
            _rootRepository = rootRepository;
            _mapperConfig = new ProductMapperConfiguration();
        }

        private IRootRepository RootRepository => _rootRepository;

        private IMapper Mapper => _mapperConfig.Mapper;

        public Task<AppOpResult<IEnumerable<ProductAttributeDto>>> GetAllProductAttributes()
        {
            throw new NotImplementedException(); // TODO
        }

        [Obsolete("For debugging")]
        public AppOpResult<IEnumerable<ProductDto>> GetAllProducts()
        {
            var products = RootRepository.Products.GetAll().ToArray();
            var productsDtos = Mapper.Map<IEnumerable<ProductDto>>(products);

            var result = new AppOpResult<IEnumerable<ProductDto>>(productsDtos);
            return result;
        }

        public AppOpResult<IEnumerable<ProductDto>> GetProductsBySubCategoryId(string subCategoryId)
        {
            var products = RootRepository.Products
                .FindByCondition(product => product.SubCategoryId == subCategoryId);
            var productsDtos = Mapper.Map<IEnumerable<ProductDto>>(products);

            var result = new AppOpResult<IEnumerable<ProductDto>>(productsDtos);
            return result;
        }

        public async Task<AppOpResult<ProductWithAdditionalInfoDto>> GetProductWithAdditionalInfoByIdAsync(string id, CancellationToken ct = default)
        {
            var product = await RootRepository.Products.FindByIdAsync(id, ct);

            if(product is null)
            {
                var errResult = new ProductNotFoundOpResult();
                return errResult;
            }

            await RootRepository.Products.LoadAttributesAndTheirValuesAsync(product, ct);

            var dto = Mapper.Map<Product, ProductWithAdditionalInfoDto>(product);
            var result = new AppOpResult<ProductWithAdditionalInfoDto>(dto);

            return result;
        }
        

        private sealed class ProductNotFoundOpResult : AppOpResult<ProductWithAdditionalInfoDto>
        {
            public ProductNotFoundOpResult() : base()
            {
                FaultResult = new AppProblemDetails
                {
                    Title = "Product not found.",
                    Detail = "Product with specified Id is not found.",
                    StatusCode = StatusCodes.Status404NotFound,
                };
            }
        }
    }
}
