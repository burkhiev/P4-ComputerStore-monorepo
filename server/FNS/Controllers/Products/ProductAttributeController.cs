using FNS.Services.Abstractions;
using FNS.Services.Dtos.Products;
using FNS.Services.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FNS.Presentation.Controllers.Products
{
    [Authorize(Roles = AppRoleNames.Admin)]
    [ApiController]
    [Route("api/products/attrs")]
    public sealed partial class ProductAttributeController : ControllerBase
    {
        private readonly IRootService _rootService;

        public ProductAttributeController(IRootService rootService)
        {
            _rootService = rootService;
        }

        public IRootService RootService => _rootService;

        [HttpGet]
        public partial IActionResult GetAll()
        {
            var result = RootService.ProductsService.GetAllProductAttributes();

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [HttpPost]
        public partial async Task<IActionResult> CreateAsync([FromBody] ProductAttributeForCreateDto dto)
        {
            var result = await RootService.ProductsService.CreateProductAttributeAsync(dto);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [HttpPut]
        public partial async Task<IActionResult> UpdateAsync([FromBody] ProductAttributeDto dto)
        {
            var result = await RootService.ProductsService.UpdateProductAttribute(dto);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [HttpDelete("{id}")]
        public partial async Task<IActionResult> DeleteAsync([FromRoute] string id)
        {
            var result = await RootService.ProductsService.DeleteProductAttributeAsync(id);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return NoContent();
        }
    }
}
