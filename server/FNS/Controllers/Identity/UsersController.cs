using FNS.Services.Abstractions;
using FNS.Services.Utils.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FNS.Presentation.Controllers.Identity
{
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

        [HttpGet("for-admins")]
        [Authorize(Roles = AppRoleNames.Admin)]
        public partial async Task<IActionResult> GetAll()
        {
            var result = RootService.UserService.GetAllUsers();
            return Ok(result.SucceedResult);
        }

        [HttpGet("for-admins/{id}")]
        [Authorize(Roles = AppRoleNames.Admin)]
        public partial async Task<IActionResult> GetByIdForAdminsAsync([FromRoute] string id)
        {
            var result = await RootService.UserService.GetUserByIdAsync(id);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [HttpGet("{id}")]
        [Authorize]
        public partial async Task<IActionResult> GetBySelfAsync([FromRoute] string id)
        {
            string? currentUserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if(string.IsNullOrEmpty(currentUserId) || currentUserId != id)
            {
                return BadRequest();
            }

            var result = await RootService.UserService.GetUserByIdAsync(currentUserId);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }
    }
}
