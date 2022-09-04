using FNS.Contexts.Infrastructure;
using FNS.Domain.Models.Products;
using FNS.Domain.Repositories.Products;
using Microsoft.EntityFrameworkCore;

namespace FNS.ContextsInfrastructure.Repositories.Products
{
    internal sealed class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext db) : base(db)
        {
            // do nothing
        }

        public async Task<Product> LoadAttributesAndTheirValuesAsync(Product product, CancellationToken ct)
        {
            await Db.ProductAttributeValues
                .Where(p => p.ProductId == product.Id)
                .Include(p => p.ProductAttribute)
                .LoadAsync(ct);

            return product;
        }
    }
}
