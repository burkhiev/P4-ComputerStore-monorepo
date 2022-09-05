using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions;
using FNS.Services.Dtos.Products;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FNS.Presentation.Controllers
{
    [ApiController]
    [Route("api/products/attrs")]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class ProductAttributeController : ControllerBase
    {
        private readonly IRootService _rootService;

        public ProductAttributeController(IRootService rootService)
        {
            _rootService = rootService;
        }

        public IRootService RootService => _rootService;

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ProductAttributeDto>), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        public IActionResult GetAll()
        {
            var result = RootService.ProductsService.GetAllProductAttributes();

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpPost]
        [ProducesResponseType(typeof(ProductAttributeDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        public async Task<IActionResult> Create(ProductAttributeForCreateDto dto)
        {
            var result = await RootService.ProductsService.CreateProductAttributeAsync(dto);

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpPut]
        [ProducesResponseType(typeof(ProductAttributeDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public async Task<IActionResult> Update(ProductAttributeDto dto)
        {
            var result = await RootService.ProductsService.UpdateProductAttribute(dto);

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ProductAttributeDto), StatusCodes.Status204NoContent, MediaTypeNames.Application.Json)]
        public async Task<IActionResult> Delete([Bind("id")] string id)
        {
            var result = await RootService.ProductsService.DeleteProductAttributeAsync(id);

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return NoContent();
        }
    }
}
