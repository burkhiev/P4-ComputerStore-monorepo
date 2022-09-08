using FNS.Services.Abstractions;
using FNS.Services.Utils.Constants;
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
        public partial IActionResult GetAllPurchaseInvoices()
        {
            var result = RootService.PurchasesService.GetAllInvoices();
            return Ok(result.SuceedResult);
        }

        [HttpGet("items/{invoiceId}")]
        public partial async Task<IActionResult> GetPurchaseInvoiceWithItemsAsync([Bind("invoiceId")] string invoiceId)
        {
            var result = await RootService.PurchasesService.GetInvoiceItemsByInvoiceId(invoiceId);
            
            if(result.Faulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }
    }
}
