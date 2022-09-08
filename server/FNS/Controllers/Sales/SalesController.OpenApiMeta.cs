using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos.SalesReceipts;
using FNS.Services.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FNS.Presentation.Controllers.Sales
{
    [ProducesResponseType(typeof(EmptyDto), StatusCodes.Status401Unauthorized, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status500InternalServerError, MediaTypeNames.Application.Json)]
    public partial class SalesController
    {
        [ProducesResponseType(typeof(EmptyDto), StatusCodes.Status403Forbidden, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(IEnumerable<SalesReceiptDto>), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        public partial IActionResult GetAll();

        [ProducesResponseType(typeof(EmptyDto), StatusCodes.Status403Forbidden, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(SalesReceiptWithAdditionalInfoDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> GetByIdAsync(string id);

        [ProducesResponseType(typeof(IEnumerable<SalesReceiptWithAdditionalInfoDto>), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> GetByUserIdAsync(string userId);

        [ProducesResponseType(typeof(SaleSuccessResultDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> SaleAsync(string userId, SaleDto saleInfo);
    }
}
