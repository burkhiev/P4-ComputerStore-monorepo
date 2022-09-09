using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos;
using FNS.Services.Dtos.Identity;

namespace FNS.Services.Abstractions.Indentity
{
    public interface IUsersService
    {
        //Task<OpResult<EmptyDto>> MarkAsAttendedAsync(string userId);
        OpResult<IEnumerable<UserDto>> GetAllUsers();
        Task<OpResult<UserDto>> GetUserByIdAsync(string id);
    }
}
