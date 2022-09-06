using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FNS.Presentation.Controllers
{
    [Route("api/users")]
    [ApiController]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status500InternalServerError, MediaTypeNames.Application.Json)]
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
            return Ok(result.SuceedResult);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var result = await RootService.UserService.GetUserByIdAsync(id);

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }
    }
}
