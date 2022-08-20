using FNS.Domain.Models.Products;
using FNS.Domain.Repositories.Products;

namespace FNS.Infrastructure.Repositories.Products
{
    internal sealed class ProductAttributeValueRepository : RepositoryBase<ProductAttributeValue>, IProductAttributeValueRepository
    {
        public ProductAttributeValueRepository(AppDbContext db)
            : base(db)
        {

        }
    }
}
