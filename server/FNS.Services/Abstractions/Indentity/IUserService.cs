using FNS.Domain.Models.Identity;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos;
using FNS.Services.Dtos.Identity;
using Microsoft.AspNetCore.Identity;

namespace FNS.Services.Abstractions.Indentity
{
    public interface IUsersService
    {
        //Task<OpResult<EmptyDto>> MarkAsAttendedAsync(string userId);
        OpResult<IEnumerable<UserDto>> GetAllUsers();
        Task<OpResult<UserDto>> GetUserByIdAsync(string id);
        Task<OpResult<UserDto>> CreateUserAsync(UserManager<User> userManager, RegisterDto dto);
        Task<OpResult<EmptyDto>> DeleteUserAsync(UserManager<User> userManager, UserDeletingDto dto);
    }
}
