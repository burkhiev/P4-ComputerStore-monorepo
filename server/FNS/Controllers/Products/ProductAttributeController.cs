using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions;
using FNS.Services.Dtos.Products;
using FNS.Services.Utils.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

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

            if(result.Failed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [HttpPost]
        public partial async Task<IActionResult> CreateAsync(ProductAttributeForCreateDto dto)
        {
            var result = await RootService.ProductsService.CreateProductAttributeAsync(dto);

            if(result.Failed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [HttpPut]
        public partial async Task<IActionResult> UpdateAsync(ProductAttributeDto dto)
        {
            var result = await RootService.ProductsService.UpdateProductAttribute(dto);

            if(result.Failed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [HttpDelete("{id}")]
        public partial async Task<IActionResult> DeleteAsync([Bind("id")] string id)
        {
            var result = await RootService.ProductsService.DeleteProductAttributeAsync(id);

            if(result.Failed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return NoContent();
        }
    }
}
