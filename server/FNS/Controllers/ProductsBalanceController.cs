using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions;
using FNS.Services.Dtos.Balances;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FNS.Presentation.Controllers
{
    [ApiController]
    [Route("api/products/balance")]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status500InternalServerError, MediaTypeNames.Application.Json)]
    public sealed class ProductsBalanceController : ControllerBase
    {
        private readonly IRootService _rootService;

        public ProductsBalanceController(IRootService rootService)
        {
            _rootService = rootService;
        }

        public IRootService RootService => _rootService;

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ProductBalanceDto>), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        public IActionResult GetAll()
        {
            var result = RootService.ProductsBalanceService.GetAll();

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ProductBalanceDto>), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        [Route("prod-id/{productId}")]
        public async Task<IActionResult> GetByProductIdAsync([Bind("productId")] string productId)
        {
            var result = await RootService.ProductsBalanceService.GetByProductIdAsync(productId);

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }
    }
}
