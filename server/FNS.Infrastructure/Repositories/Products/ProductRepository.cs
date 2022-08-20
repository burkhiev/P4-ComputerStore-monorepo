using FNS.Domain.Models.Products;
using FNS.Domain.Repositories.Products;
using Microsoft.EntityFrameworkCore;

namespace FNS.Infrastructure.Repositories.Products
{
    internal sealed class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext db)
            : base(db)
        {
            
        }

        public async Task<Product?> FindWithIncludesAsync(Guid id, CancellationToken ct)
        {
            var product = await FindByIdAsync(id, ct);

            if(product is null)
            {
                return null;
            }

            await Db.ProductAttributeValues.Where(x => x.ProductId == product.Id)
                .Include(x => x.Product)
                .Include(x => x.ProductAttribute)
                .LoadAsync();

            return product;
        }
    }
}
