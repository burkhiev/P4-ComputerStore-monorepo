using FNS.Services.Abstractions;
using FNS.Services.Dtos.Products;
using FNS.Services.Utils.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FNS.Presentation.Controllers.Products
{
    [ApiController]
    [Route("api/products")]
    public sealed partial class ProductsController : ControllerBase
    {
        private readonly IRootService _rootService;

        public ProductsController(IRootService rootService)
        {
            _rootService = rootService;
        }

        private IRootService RootService => _rootService;

        [HttpGet]
        public partial IActionResult GetAll()
        {
            var result = RootService.ProductsService.GetAllProducts();

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [HttpGet("sub-category/{subCategoryId}")]
        public partial IActionResult GetProductsByCategoryId([FromRoute] string subCategoryId)
        {
            var result = RootService.ProductsService.GetProductsBySubCategoryId(subCategoryId);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [HttpGet("{id}")]
        public partial async Task<IActionResult> GetWithAdditionalInfoAsync([FromRoute] string id)
        {
            var result = await RootService.ProductsService.GetProductWithAdditionalInfoByIdAsync(id);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [Authorize(Roles = AppRoleNames.Admin)]
        [HttpPost]
        public partial async Task<IActionResult> CreateAsync([FromBody] ProductForCreateDto dto)
        {
            var result = await RootService.ProductsService.CreateProduct(dto);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [Authorize(Roles = AppRoleNames.Admin)]
        [HttpPut]
        public partial async Task<IActionResult> UpdateAsync([FromBody] ProductWithAdditionalInfoDto dto)
        {
            var result = await RootService.ProductsService.UpdateProduct(dto);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [Authorize(Roles = AppRoleNames.Admin)]
        [HttpDelete("{id}")]
        public partial async Task<IActionResult> DeleteAsync([FromRoute] string id)
        {
            var result = await RootService.ProductsService.DeleteProductAsync(id);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return NoContent();
        }

        [Authorize(Roles = AppRoleNames.Admin)]
        [HttpPost("upload")]
        public partial async Task<IActionResult> LoadProductsFromJson(IFormFile file)
        {
            var result = await RootService.ProductsService.LoadProductsFromJson(file);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return NoContent();
        }
    }
}
