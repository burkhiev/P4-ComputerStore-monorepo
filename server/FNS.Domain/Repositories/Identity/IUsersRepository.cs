using FNS.Domain.Models.Identity;

namespace FNS.Domain.Repositories.Identity
{
    public interface IUsersRepository : IRepositoryBase<User>
    {
        Task<User> LoadAdditionalInfoAsync(User user);
    }
}
