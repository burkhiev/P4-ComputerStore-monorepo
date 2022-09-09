using Microsoft.AspNetCore.Identity;

namespace FNS.Domain.Repositories.Identity
{
    public interface IUserRolesRepository : IRepositoryBase<IdentityUserRole<string>>
    {
    }
}
