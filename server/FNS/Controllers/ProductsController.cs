using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FNS.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public sealed class ProductsController : ControllerBase
    {
        private readonly IRootService _rootService;

        public ProductsController(IRootService rootService)
        {
            _rootService = rootService;
        }

        private IRootService RootService => _rootService;

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllProducts()
        {
            var result = RootService.ProductsService.GetAllProductsDtos();

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SucceedResult);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetAdditionalProductInfo(Guid id)
        {
            var result = await RootService.ProductsService.GetProductAdditionalInfoAsync(id);

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SucceedResult);
        }
    }
}
