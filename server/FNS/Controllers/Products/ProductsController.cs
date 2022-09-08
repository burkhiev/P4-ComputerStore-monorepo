using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Abstractions;
using FNS.Services.Dtos.Products;
using FNS.Services.Utils.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

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

            if(result.Faulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpGet("sub-category/{subCategoryId}")]
        public partial IActionResult GetProductsByCategoryId([Bind("subCategoryId")] string subCategoryId)
        {
            var result = RootService.ProductsService.GetProductsBySubCategoryId(subCategoryId);

            if(result.Faulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpGet("{id}")]
        public partial async Task<IActionResult> GetWithAdditionalInfoAsync([Bind("id")] string id)
        {
            var result = await RootService.ProductsService.GetProductWithAdditionalInfoByIdAsync(id);

            if(result.Faulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [Authorize(Roles = AppRoleNames.Admin)]
        [HttpPost]
        public partial async Task<IActionResult> CreateAsync(ProductForCreateDto dto)
        {
            var result = await RootService.ProductsService.CreateProduct(dto);

            if(result.Faulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [Authorize(Roles = AppRoleNames.Admin)]
        [HttpPut]
        public partial async Task<IActionResult> UpdateAsync(ProductWithAdditionalInfoDto dto)
        {
            var result = await RootService.ProductsService.UpdateProduct(dto);

            if(result.Faulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [Authorize(Roles = AppRoleNames.Admin)]
        [HttpDelete("{id}")]
        public partial async Task<IActionResult> DeleteAsync([Bind("id")] string id)
        {
            var result = await RootService.ProductsService.DeleteProductAsync(id);

            if(result.Faulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return NoContent();
        }
    }
}
