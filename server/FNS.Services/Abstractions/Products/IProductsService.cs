using FNS.Domain.Models;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos.Products;

namespace FNS.Services.Abstractions.Products
{
    public interface IProductsService
    {
        AppOpResult<IEnumerable<ProductDto>> GetAllProducts();
        AppOpResult<IEnumerable<ProductDto>> GetProductsBySubCategoryId(string subCategoryId);
        Task<AppOpResult<ProductWithAdditionalInfoDto>> GetProductWithAdditionalInfoByIdAsync(string id, CancellationToken ct = default);
        Task<AppOpResult<ProductWithAdditionalInfoDto>> CreateProduct(ProductForCreateDto dto);
        Task<AppOpResult<ProductWithAdditionalInfoDto>> UpdateProduct(ProductWithAdditionalInfoDto dto);
        Task<AppOpResult<DummyModel>> DeleteProductAsync(string id);
        AppOpResult<IEnumerable<ProductAttributeDto>> GetAllProductAttributes();
        Task<AppOpResult<ProductAttributeDto>> CreateProductAttributeAsync(ProductAttributeForCreateDto attrDto);
        Task<AppOpResult<ProductAttributeDto>> UpdateProductAttribute(ProductAttributeDto attrDto);
        Task<AppOpResult<DummyModel>> DeleteProductAttributeAsync(string id);
    }
}
