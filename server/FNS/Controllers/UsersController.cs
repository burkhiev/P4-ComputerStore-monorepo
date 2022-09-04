using FNS.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace FNS.Presentation.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IRootService _rootService;

        public UsersController(IRootService rootService)
        {
            _rootService = rootService;
        }

        public IRootService RootService => _rootService;

        [HttpGet]
        public IActionResult Get()
        {
            var result = RootService.UserService.GetAllUsers();
            return Ok(result.Result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var result = await RootService.UserService.GetUserByIdAsync(id);

            if(result.IsFaulted)
            {
                return StatusCode(result.ProblemDetails.StatusCode, result.ProblemDetails);
            }

            return Ok(result.Result);
        }
    }
}
