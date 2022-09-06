using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions;
using FNS.Services.Dtos.Purchases;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FNS.Presentation.Controllers
{
    [ApiController]
    [Route("api/purchase-invoices")]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status500InternalServerError, MediaTypeNames.Application.Json)]
    public sealed class PurchaseController : ControllerBase
    {
        private readonly IRootService _rootService;

        public PurchaseController(IRootService rootService)
        {
            _rootService = rootService;
        }

        public IRootService RootService => _rootService;

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<PurchaseInvoiceDto>), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        public IActionResult GetAllPurchaseInvoices()
        {
            var result = RootService.PurchasesService.GetAllInvoices();
            return Ok(result.SuceedResult);
        }

        [HttpGet("items/{invoiceId}")]
        [ProducesResponseType(typeof(IEnumerable<PurchaseInvoiceDto>), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetAllPurchaseInvoiceItemsAsync([Bind("invoiceId")] string invoiceId)
        {
            var result = await RootService.PurchasesService.GetInvoiceItemsByInvoiceId(invoiceId);
            
            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpPost("items")]
        [ProducesResponseType(typeof(PurchaseInvoiceDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetAllPurchaseInvoicesItemsAsync([Bind("invoiceId")] string invoiceId)
        {
            var result = await RootService.PurchasesService.GetInvoiceItemsByInvoiceId(invoiceId);

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }
    }
}
