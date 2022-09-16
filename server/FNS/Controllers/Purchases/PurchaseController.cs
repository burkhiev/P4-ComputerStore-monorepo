using System.Security.Claims;
using FNS.Services.Abstractions;
using FNS.Services.Dtos.Purchases;
using FNS.Services.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FNS.Presentation.Controllers.Purchases
{
    [Authorize(Roles = AppRoleNames.Admin)]
    [ApiController]
    [Route("api/purchase-invoices")]
    public sealed partial class PurchaseController : ControllerBase
    {
        private readonly IRootService _rootService;

        public PurchaseController(IRootService rootService)
        {
            _rootService = rootService;
        }

        public IRootService RootService => _rootService;

        [HttpGet]
        public partial async Task<IActionResult> GetAllPurchaseInvoices()
        {
            var result = await RootService.PurchasesService.GetAllInvoicesAsync();
            return Ok(result.SucceedResult);
        }

        [HttpGet("{invoiceId}/items")]
        public partial async Task<IActionResult> GetPurchaseInvoiceWithItemsAsync([FromRoute] string invoiceId)
        {
            var result = await RootService.PurchasesService.GetInvoiceItemsByInvoiceId(invoiceId);
            
            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [HttpPost("users/{userId}")]
        public partial async Task<IActionResult> MakePurchaseAsync(
            [FromRoute] string userId, 
            [FromBody] PurchaseInvoiceForCreateDto dto)
        {
            string? identityId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if(userId != dto.UserId || userId != identityId)
            {
                return BadRequest();
            }

            var result = await RootService.PurchasesService.MakePurchaseAsync(dto);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }
    }
}
