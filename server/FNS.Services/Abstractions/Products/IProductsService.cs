using FNS.Domain.Models.Products;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos.Products;

namespace FNS.Services.Abstractions.Products
{
    public interface IProductsService : IServiceBase<Product>
    {
        AppOpResult<IEnumerable<ProductDto>> GetAllProducts();
        AppOpResult<IEnumerable<ProductDto>> GetProductsBySubCategoryId(string subCategoryId);
        Task<AppOpResult<ProductWithAdditionalInfoDto>> GetProductWithAdditionalInfoByIdAsync(string id, CancellationToken ct = default);
    }
}
