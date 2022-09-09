using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos;
using FNS.Services.Dtos.Products;

namespace FNS.Services.Abstractions.Products
{
    public interface IProductsService
    {
        OpResult<IEnumerable<ProductDto>> GetAllProducts();
        OpResult<IEnumerable<ProductDto>> GetProductsBySubCategoryId(string subCategoryId);
        Task<OpResult<ProductWithAdditionalInfoDto>> GetProductWithAdditionalInfoByIdAsync(string id);
        Task<OpResult<ProductWithAdditionalInfoDto>> CreateProduct(ProductForCreateDto dto);
        Task<OpResult<ProductWithAdditionalInfoDto>> UpdateProduct(ProductWithAdditionalInfoDto dto);
        Task<OpResult<EmptyDto>> DeleteProductAsync(string id);
        OpResult<IEnumerable<ProductAttributeDto>> GetAllProductAttributes();
        Task<OpResult<ProductAttributeDto>> CreateProductAttributeAsync(ProductAttributeForCreateDto attrDto);
        Task<OpResult<ProductAttributeDto>> UpdateProductAttribute(ProductAttributeDto attrDto);
        Task<OpResult<EmptyDto>> DeleteProductAttributeAsync(string id);
        OpResult<IEnumerable<SubCategoryDto>> GetAllSubCategories();
        Task<OpResult<SubCategoryDto>> CreateSubCategoryAsync(SubCategoryForCreateDto attrDto);
        Task<OpResult<SubCategoryDto>> UpdateSubCategoryAsync(SubCategoryDto attrDto);
        Task<OpResult<EmptyDto>> DeleteSubCategoryAsync(string id);
    }
}
