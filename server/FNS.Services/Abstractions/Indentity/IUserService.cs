using FNS.Domain.Models.Identity;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos.Identity;

namespace FNS.Services.Abstractions.Indentity
{
    public interface IUserService : IServiceBase<User>
    {
        AppOpResult<IEnumerable<UserDto>> GetAllUsers();
        Task<AppOpResult<UserDto>> GetUserByIdAsync(string id, CancellationToken ct = default);
    }
}
