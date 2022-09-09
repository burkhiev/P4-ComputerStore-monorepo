using FNS.Contexts.Infrastructure;
using FNS.ContextsInfrastructure.Repositories.Products;
using FNS.Domain.Models.Identity;
using FNS.Domain.Repositories.Identity;

namespace FNS.Infrastructure.Repositories.Identity
{
    internal sealed class RoleRepository : RepositoryBase<Role>, IRolesRepository
    {
        public RoleRepository(AppDbContext db) : base(db)
        {
            // nothing
        }
    }
}
