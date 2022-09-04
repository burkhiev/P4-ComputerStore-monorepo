using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FNS.Presentation.Controllers
{
    [Route("api/products")]
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
            var result = RootService.ProductsService.GetAllProducts();

            if(result.IsFaulted)
            {
                return StatusCode(result.ProblemDetails.StatusCode, result.ProblemDetails);
            }

            return Ok(result.Result);
        }

        [HttpGet("sub-category/{subCategoryId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetProductsByCategoryId([Bind("subCategoryId")] string subCategoryId)
        {
            var result = RootService.ProductsService.GetProductsBySubCategoryId(subCategoryId);

            if(result.IsFaulted)
            {
                return StatusCode(result.ProblemDetails.StatusCode, result.ProblemDetails);
            }

            return Ok(result.Result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetAdditionalProductInfo([Bind("id")] string id)
        {
            var result = await RootService.ProductsService.GetProductWithAdditionalInfoByIdAsync(id);

            if(result.IsFaulted)
            {
                return StatusCode(result.ProblemDetails.StatusCode, result.ProblemDetails);
            }

            return Ok(result.Result);
        }
    }
}
