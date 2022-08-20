using AutoMapper;
using FNS.Domain.Repositories;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions.Products;
using FNS.Services.Dtos.Products;
using FNS.Services.Mappers.Products;
using Microsoft.AspNetCore.Http;
using System.Dynamic;

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

        public AppOperationResult<IEnumerable<ProductDto>> GetAllProductsDtos()
        {
            var products = RootRepository.ProductRepositoryManager.ProductRepository.GetAll();
            var productsDtos = _mapper.ProjectTo<ProductDto>(products);

            var result = new AppOperationResult<IEnumerable<ProductDto>>(productsDtos);
            return result;
        }

        public async Task<AppOperationResult<ProductAdditionalInfoDto>> GetProductAdditionalInfoAsync(Guid id, CancellationToken ct = default)
        {
            var product = await RootRepository.ProductRepositoryManager.ProductRepository.FindWithIncludesAsync(id, ct);

            if(product is null)
            {
                var errResult = new ProductNotFoundOperationResult();
                return errResult;
            }

            var additionalInfo = _mapper.Map<ProductAdditionalInfoDto>(product);
            dynamic[] resultAttrValues = new ExpandoObject[product.ProductAttributeValues.Count];

            for(int i = 0; i < product.ProductAttributeValues.Count; i++)
            {
                var attrValue = product.ProductAttributeValues[i];
                var attribute = attrValue.ProductAttribute;

                resultAttrValues[i] = new ExpandoObject();
                resultAttrValues[i].Name = attrValue.ProductAttribute.Name;

                if(attribute.Measure is not null)
                {
                    resultAttrValues[i].Measure = attribute.Measure;
                }

                if(attrValue.Value is null)
                {
                    resultAttrValues[i].Value = null;
                }
                else if(attribute.ClrType.Equals(typeof(string).Name, StringComparison.OrdinalIgnoreCase))
                {
                    resultAttrValues[i].Value = attrValue.Value;
                }
                else if(attribute.ClrType.Equals(typeof(int).Name, StringComparison.OrdinalIgnoreCase))
                {
                    resultAttrValues[i].Value = int.Parse(attrValue.Value);
                }
                else if(attribute.ClrType.Equals(typeof(float).Name, StringComparison.OrdinalIgnoreCase))
                {
                    resultAttrValues[i].Value = float.Parse(attrValue.Value);
                }
                else if(attribute.ClrType.Equals(typeof(double).Name, StringComparison.OrdinalIgnoreCase))
                {
                    resultAttrValues[i].Value = double.Parse(attrValue.Value);
                }
                else if(attribute.ClrType.Equals(typeof(decimal).Name, StringComparison.OrdinalIgnoreCase))
                {
                    resultAttrValues[i].Value = decimal.Parse(attrValue.Value);
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            additionalInfo.Attributes = resultAttrValues;
            var result = new AppOperationResult<ProductAdditionalInfoDto>(additionalInfo);

            return result;
        }

        private sealed class ProductNotFoundOperationResult : AppOperationResult<ProductAdditionalInfoDto>
        {
            public ProductNotFoundOperationResult() : base()
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
