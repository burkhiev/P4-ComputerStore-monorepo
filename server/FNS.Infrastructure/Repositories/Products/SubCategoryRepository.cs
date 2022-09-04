using FNS.Domain.Models.Products;
using FNS.Domain.Repositories.Products;
using FNS.Contexts.Infrastructure;

namespace FNS.ContextsInfrastructure.Repositories.Products
{
    internal sealed class SubCategoryRepository : RepositoryBase<SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(AppDbContext db) : base(db)
        {
            // do nothing
        }
    }
}
