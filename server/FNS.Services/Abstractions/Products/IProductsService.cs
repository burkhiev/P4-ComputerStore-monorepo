using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos;
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
        Task<AppOpResult<EmptyDto>> DeleteProductAsync(string id);
        AppOpResult<IEnumerable<ProductAttributeDto>> GetAllProductAttributes();
        Task<AppOpResult<ProductAttributeDto>> CreateProductAttributeAsync(ProductAttributeForCreateDto attrDto);
        Task<AppOpResult<ProductAttributeDto>> UpdateProductAttribute(ProductAttributeDto attrDto);
        Task<AppOpResult<EmptyDto>> DeleteProductAttributeAsync(string id);
        AppOpResult<IEnumerable<SubCategoryDto>> GetAllSubCategories();
        Task<AppOpResult<SubCategoryDto>> CreateSubCategoryAsync(SubCategoryForCreateDto attrDto);
        Task<AppOpResult<SubCategoryDto>> UpdateSubCategoryAsync(SubCategoryDto attrDto);
        Task<AppOpResult<EmptyDto>> DeleteSubCategoryAsync(string id);
    }
}
