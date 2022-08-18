using FNS.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FNS.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class ProductsController : ControllerBase
    {
        private readonly IRootService _rootService;

        public ProductsController(IRootService rootService)
        {
            _rootService = rootService;
        }

        private IRootService RootService => _rootService;

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var result = RootService.ProductsService.GetProductsDtos();

            if(result.IsFaulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SucceedResult);
        }

        [HttpGet("{id}")]
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
