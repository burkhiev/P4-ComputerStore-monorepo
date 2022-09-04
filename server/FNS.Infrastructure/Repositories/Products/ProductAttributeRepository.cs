using FNS.Contexts.Infrastructure;
using FNS.Domain.Models.Products;
using FNS.Domain.Repositories.Products;

namespace FNS.ContextsInfrastructure.Repositories.Products
{
    internal sealed class ProductAttributeRepository : RepositoryBase<ProductAttribute>, IProductAttributeRepository
    {
        public ProductAttributeRepository(AppDbContext db)
            : base(db)
        {
            // do nothing
        }
    }
}
