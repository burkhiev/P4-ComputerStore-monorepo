using FNS.Domain.Models.Products;

namespace FNS.Domain.Repositories.Products
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        Task<Product> LoadAttributesAndTheirValuesAsync(Product product);
    }
}
