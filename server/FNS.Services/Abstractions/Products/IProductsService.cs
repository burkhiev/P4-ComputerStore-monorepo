using FNS.Domain.Models.Products;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos.Products;

namespace FNS.Services.Abstractions.Products
{
    public interface IProductsService : IServiceBase<Product>
    {
        AppOperationResult<IEnumerable<ProductDto>> GetAllProductsDtos();
        Task<AppOperationResult<ProductAdditionalInfoDto>> GetProductAdditionalInfoAsync(Guid id, CancellationToken ct = default);
    }
}
