using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions;
using FNS.Services.Dtos.ShoppingCarts;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FNS.Presentation.Controllers
{
    [ApiController]
    [Route("api/carts")]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class ShoppingCartsController : Controller
    {
        private readonly IRootService _rootService;

        public ShoppingCartsController(IRootService rootService)
        {
            _rootService = rootService;
        }

        public IRootService RootService => _rootService;

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ShoppingCartDto>), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        public IActionResult GetAllCarts()
        {
            var result = RootService.ShoppingCartService.GetAll();
            return Ok(result.Result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ShoppingCartDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetCartById(string id)
        {
            var result = await RootService.ShoppingCartService.GetByIdWithAdditionalInfoAsync(id);

            if(result.IsFaulted)
            {
                return StatusCode(result.ProblemDetails.StatusCode, result.ProblemDetails);
            }

            return Ok(result.Result);
        }

        [HttpGet("user/{userId}")]
        [ProducesResponseType(typeof(ShoppingCartDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetByUserId(string userId)
        {
            var result = await RootService.ShoppingCartService.GetByUserIdAsync(userId);

            if(result.IsFaulted)
            {
                return StatusCode(result.ProblemDetails.StatusCode, result.ProblemDetails);
            }

            return Ok(result.Result);
        }
    }
}
