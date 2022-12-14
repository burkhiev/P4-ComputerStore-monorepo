using System.Security.Claims;
using FNS.Services.Abstractions;
using FNS.Services.Utils.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FNS.Presentation.Controllers.Sales
{
    [Authorize]
    [ApiController]
    [Route("api/sales")]
    public sealed partial class SalesController : ControllerBase
    {
        private readonly IRootService _rootService;

        public SalesController(IRootService rootService)
        {
            _rootService = rootService;
        }

        public IRootService RootService => _rootService;

        [Authorize(Roles = AppRoleNames.Admin)]
        [HttpGet]
        public partial IActionResult GetAll()
        {
            var result = RootService.SalesReceiptService.GetAll();

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [Authorize(Roles = AppRoleNames.Admin)]
        [HttpGet("{id}")]
        public partial async Task<IActionResult> GetByIdAsync([FromRoute] string id)
        {
            var result = await RootService.SalesReceiptService.GetWithAdditionalInfoAsync(id);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [HttpGet("users/{userId}")]
        public partial async Task<IActionResult> GetByUserIdAsync([FromRoute] string userId)
        {
            string? identityId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if(identityId != userId)
            {
                return BadRequest();
            }


            var result = await RootService.SalesReceiptService.GetByUserIdAsync(userId);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [HttpPost("users/{userId}")]
        public partial async Task<IActionResult> SaleAsync([FromRoute] string userId)
        {
            string? identityId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if(identityId != userId)
            {
                return BadRequest();
            }


            var result = await RootService.SalesReceiptService.MakeSaleAsync(userId);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }
    }
}
