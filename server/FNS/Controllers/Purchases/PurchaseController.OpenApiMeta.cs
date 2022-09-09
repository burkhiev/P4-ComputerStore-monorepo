using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos.Purchases;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FNS.Presentation.Controllers.Purchases
{
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(EmptyResult), StatusCodes.Status401Unauthorized, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(EmptyResult), StatusCodes.Status403Forbidden, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(ProblemResultInfo), StatusCodes.Status500InternalServerError, MediaTypeNames.Application.Json)]
    public partial class PurchaseController
    {
        [ProducesResponseType(typeof(IEnumerable<PurchaseInvoiceDto>), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> GetAllPurchaseInvoices();

        [ProducesResponseType(typeof(IEnumerable<PurchaseInvoiceItemDto>), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ProblemResultInfo), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> GetPurchaseInvoiceWithItemsAsync(string invoiceId);

        [ProducesResponseType(typeof(PurchaseInvoiceDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ProblemResultInfo), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> MakePurchaseAsync(string userId, PurchaseInvoiceForCreateDto dto);
    }
}
