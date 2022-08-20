using FNS.Domain.Models.Products;
using FNS.Domain.Repositories.Products;

namespace FNS.Infrastructure.Repositories.Products
{
    internal sealed class SubCategoryRepository : RepositoryBase<SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(AppDbContext db)
            : base(db)
        {

        }
    }
}
