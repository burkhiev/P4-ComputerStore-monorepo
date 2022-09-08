using FNS.Services.Abstractions;
using FNS.Services.Utils.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FNS.Presentation.Controllers.Identity
{
    [Authorize]
    [ApiController]
    [Route("api/users")]
    public sealed partial class UsersController : ControllerBase
    {
        private readonly IRootService _rootService;

        public UsersController(IRootService rootService)
        {
            _rootService = rootService;
        }

        public IRootService RootService => _rootService;

        [Authorize(Roles = AppRoleNames.Admin)]
        [HttpGet("for-admins")]
        public partial IActionResult GetAll()
        {
            var result = RootService.UserService.GetAllUsers();
            return Ok(result.SuceedResult);
        }

        [Authorize(Roles = AppRoleNames.Admin)]
        [HttpGet("for-admins/{id}")]
        public partial async Task<IActionResult> GetByIdForAdminsAsync(string id)
        {
            var result = await RootService.UserService.GetUserByIdAsync(id);

            if(result.Faulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpGet("{id}")]
        public partial async Task<IActionResult> GetBySelfAsync(string id)
        {
            string? currentUserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if(currentUserId is null || currentUserId != id)
            {
                return BadRequest();
            }

            var result = await RootService.UserService.GetUserByIdAsync(currentUserId);

            if(result.Faulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }
    }
}
