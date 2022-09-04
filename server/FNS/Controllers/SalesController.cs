using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions;
using FNS.Services.Dtos.SalesReceipts;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FNS.Presentation.Controllers
{
    [Route("api/sales")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public sealed class SalesController : ControllerBase
    {
        private readonly IRootService _rootService;

        public SalesController(IRootService rootService)
        {
            _rootService = rootService;
        }

        public IRootService RootService => _rootService;

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<SalesReceiptDto>), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        public IActionResult Get()
        {
            var result = RootService.SalesReceiptService.GetAll();

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(SalesReceiptWithAdditionalInfoDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public async Task<IActionResult> Get([Bind("id")] string id)
        {
            var result = await RootService.SalesReceiptService.GetWithAdditionalAsync(id);

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpPost]
        [ProducesResponseType(typeof(SaleSuccessResultDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
        public async Task<IActionResult> Sale([Bind($"saleInfo")] SaleDto saleInfo)
        {
            var result = await RootService.SalesReceiptService.MakeSaleAsync(saleInfo);

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }
    }
}
