using System.Security.Claims;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions;
using FNS.Services.Dtos.ShoppingCarts;
using FNS.Services.Utils.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FNS.Presentation.Controllers.ShoppingCarts
{
    [Authorize]
    [ApiController]
    [Route("api/carts")]
    public partial class ShoppingCartsController : ControllerBase
    {
        private readonly IRootService _rootService;

        public ShoppingCartsController(IRootService rootService)
        {
            _rootService = rootService;
        }

        public IRootService RootService => _rootService;

        [Authorize(Roles = AppRoleNames.Admin)]
        [HttpGet]
        public partial IActionResult GetAll()
        {
            var result = RootService.ShoppingCartService.GetAll();
            return Ok(result.SucceedResult);
        }

        [HttpGet("users/{userId}")]
        public partial async Task<IActionResult> GetByUserIdWithAdditionalInfoAsync([FromRoute] string userId)
        {
            string? identityId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if(identityId != userId)
            {
                return BadRequest();
            }


            var result = await RootService.ShoppingCartService.GetByUserIdWithAdditionalInfoAsync(userId);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [HttpPost("users/{userId}")]
        public partial async Task<IActionResult> AddCartItemAsync(
            [FromRoute] string userId, 
            [FromBody] ShoppingCartItemForCreateDto dto)
        {
            string? identityId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if(identityId != userId)
            {
                return BadRequest();
            }


            if(userId != dto.UserId)
            {
                var badResult = new ProblemResultInfo
                {
                    Title = "Invalid arguments received",
                    Detail = $"Invalid {nameof(userId)} path argument.",
                    StatusCode = StatusCodes.Status400BadRequest,
                };

                return BadRequest(badResult);
            }

            var result = await RootService.ShoppingCartService.AddProductAsync(dto.UserId, dto.ProductId);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return NoContent();
        }

        [HttpPut("users/{userId}/cart-items/{itemId}")]
        public partial async Task<IActionResult> UpdateCartItemAmountAsync(
            [FromRoute, Bind("userId")] string userId,
            [FromRoute, Bind("itemId")] string itemId,
            ShoppingCartForChangeItemAmountDto dto)
        {
            string? identityId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if(userId != identityId || userId != dto.UserId || itemId != dto.ItemId)
            {
                return BadRequest();
            }

            var result = await RootService.ShoppingCartService.UpdateItemAmountAsync(dto);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [HttpDelete("users/{userId}/cart-items/{itemId}")]
        public partial async Task<IActionResult> DeleteCartItemAsync(
            [FromRoute, Bind("userId")] string userId, 
            [FromRoute, Bind("itemId")] string itemId)
        {
            string? identityId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if(identityId != userId)
            {
                return BadRequest();
            }


            var result = await RootService.ShoppingCartService.DeleteItemAsync(userId, itemId);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return NoContent();
        }
    }
}
