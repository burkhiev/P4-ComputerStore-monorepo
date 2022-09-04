using FNS.Contexts.Infrastructure;
using FNS.ContextsInfrastructure.Repositories.Products;
using FNS.Domain.Models.Identity;
using FNS.Domain.Repositories.Identity;

namespace FNS.Infrastructure.Repositories.Identity
{
    internal sealed class UsersRepository : RepositoryBase<User>, IUsersRepository
    {
        public UsersRepository(AppDbContext db) : base(db)
        {
            // do nothing
        }

        public async Task<User> LoadAdditionalInfoAsync(User user, CancellationToken ct = default)
        {
            await Db.Entry(user).Reference(u => u.ShoppingCart).LoadAsync();
            return user;
        }
    }
}
