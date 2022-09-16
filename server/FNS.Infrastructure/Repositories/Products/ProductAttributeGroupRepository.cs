using FNS.Contexts.Infrastructure;
using FNS.ContextsInfrastructure.Repositories.Products;
using FNS.Domain.Models.Products;
using FNS.Domain.Repositories.Products;

namespace FNS.Infrastructure.Repositories.Products
{
    internal sealed class ProductAttributeGroupRepository : RepositoryBase<ProductAttributeGroup>, IProductAttributeGroupRepository
    {
        public ProductAttributeGroupRepository(AppDbContext db) : base(db)
        {
            // nothing
        }
    }
}
