using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos.Identity;

namespace FNS.Services.Abstractions.Indentity
{
    public interface IUsersService
    {
        AppOpResult<IEnumerable<UserDto>> GetAllUsers();
        Task<AppOpResult<UserDto>> GetUserByIdAsync(string id);
    }
}
