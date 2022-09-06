using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions;
using FNS.Services.Dtos.Products;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FNS.Presentation.Controllers
{
    [ApiController]
    [Route("api/products")]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status500InternalServerError, MediaTypeNames.Application.Json)]
    public sealed class ProductsController : ControllerBase
    {
        private readonly IRootService _rootService;

        public ProductsController(IRootService rootService)
        {
            _rootService = rootService;
        }

        private IRootService RootService => _rootService;

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ProductDto>), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        public IActionResult GetAll()
        {
            var result = RootService.ProductsService.GetAllProducts();

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpGet("sub-category/{subCategoryId}")]
        [ProducesResponseType(typeof(IEnumerable<ProductDto>), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        public IActionResult GetProductsByCategoryId([Bind("subCategoryId")] string subCategoryId)
        {
            var result = RootService.ProductsService.GetProductsBySubCategoryId(subCategoryId);

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProductWithAdditionalInfoDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetWithAdditionalInfoAsync([Bind("id")] string id)
        {
            var result = await RootService.ProductsService.GetProductWithAdditionalInfoByIdAsync(id);

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpPost]
        [ProducesResponseType(typeof(ProductWithAdditionalInfoDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public async Task<IActionResult> CreateAsync(ProductForCreateDto dto)
        {
            var result = await RootService.ProductsService.CreateProduct(dto);

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpPut]
        [ProducesResponseType(typeof(ProductWithAdditionalInfoDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public async Task<IActionResult> UpdateAsync(ProductWithAdditionalInfoDto dto)
        {
            var result = await RootService.ProductsService.UpdateProduct(dto);

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteAsync([Bind("id")] string id)
        {
            var result = await RootService.ProductsService.DeleteProductAsync(id);

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return NoContent();
        }
    }
}
