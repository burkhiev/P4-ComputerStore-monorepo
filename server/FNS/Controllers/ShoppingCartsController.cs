using FNS.Domain.Models;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions;
using FNS.Services.Dtos;
using FNS.Services.Dtos.Identity;
using FNS.Services.Dtos.ShoppingCarts;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FNS.Presentation.Controllers
{
    [ApiController]
    [Route("api/carts")]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status500InternalServerError, MediaTypeNames.Application.Json)]
    public class ShoppingCartsController : ControllerBase
    {
        private readonly IRootService _rootService;

        public ShoppingCartsController(IRootService rootService)
        {
            _rootService = rootService;
        }

        public IRootService RootService => _rootService;

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ShoppingCartDto>), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        public IActionResult GetAll()
        {
            var result = RootService.ShoppingCartService.GetAll();
            return Ok(result.SuceedResult);
        }

        [HttpGet("users/{userId}")]
        [ProducesResponseType(typeof(ShoppingCartWithAdditionalInfoDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetByUserIdWithAdditionalInfoAsync([Bind("userId")] string userId)
        {
            var result = await RootService.ShoppingCartService.GetByUserIdWithAdditionalInfoAsync(userId);

            if(result.Faulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpPost("users/{userId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public async Task<IActionResult> AddProductItemAsync([Bind("userId")] string userId, ShoppingCartItemForCreateDto dto)
        {
            if(userId != dto.UserId)
            {
                var badResult = new AppProblemDetails
                {
                    Title = "Invalid arguments received",
                    Detail = $"Invalid {nameof(userId)} path argument.",
                    StatusCode = StatusCodes.Status400BadRequest,
                };

                return BadRequest(badResult);
            }

            var result = await RootService.ShoppingCartService.AddProductAsync(dto.UserId, dto.ProductId);

            if(result.Faulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return NoContent();
        }

        [HttpPut("users/{userId}/cart-items/{itemId}")]
        [ProducesResponseType(typeof(ShoppingCartForChangeItemAmountDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public async Task<IActionResult> UpdateShoppingCartItemAmountAsync([Bind("userId")] string userId, ShoppingCartForChangeItemAmountDto dto)
{
            var result = await RootService.ShoppingCartService.UpdateItemAmountAsync(userId, dto.ItemId, dto.Amount);

            if(result.Faulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpDelete("users/{userId}/cart-items/{itemId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> UpdateShoppingCartItemAmountAsync([Bind("userId")] string userId, [Bind("itemId")] string itemId)
        {
            var result = await RootService.ShoppingCartService.DeleteItemAsync(userId, itemId);

            if(result.Faulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return NoContent();
        }
    }
}
