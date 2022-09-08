using FNS.Services.Abstractions;
using FNS.Services.Dtos.SalesReceipts;
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

            if(result.Faulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [Authorize(Roles = AppRoleNames.Admin)]
        [HttpGet("{id}")]
        public partial async Task<IActionResult> GetByIdAsync([Bind("id")] string id)
        {
            var result = await RootService.SalesReceiptService.GetWithAdditionalInfoAsync(id);

            if(result.Faulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpGet("users/{userId}")]
        public partial async Task<IActionResult> GetByUserIdAsync([Bind("userId")] string userId)
        {
            var result = await RootService.SalesReceiptService.GetByUserIdAsync(userId);

            if(result.Faulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpPost("users/{userId}")]
        public partial async Task<IActionResult> SaleAsync([Bind("userId")] string userId, [Bind("saleInfo")] SaleDto saleInfo)
        {
            if(userId != saleInfo.UserId)
            {
                return BadRequest();
            }

            var result = await RootService.SalesReceiptService.MakeSaleAsync(saleInfo);

            if(result.Faulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }
    }
}
