using FNS.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace FNS.Presentation.Controllers.Products
{
    [ApiController]
    [Route("api/products/balance")]
    public sealed partial class ProductsBalanceController : ControllerBase
    {
        private readonly IRootService _rootService;

        public ProductsBalanceController(IRootService rootService)
        {
            _rootService = rootService;
        }

        public IRootService RootService => _rootService;

        [HttpGet]
        public partial IActionResult GetAll()
        {
            var result = RootService.ProductsBalanceService.GetAll();

            if(result.Faulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }

        [HttpGet]
        [Route("prod-id/{productId}")]
        public partial async Task<IActionResult> GetByProductIdAsync([Bind("productId")] string productId)
        {
            var result = await RootService.ProductsBalanceService.GetByProductIdAsync(productId);

            if(result.Faulted)
            {
                return StatusCode(result.FaultResult.StatusCode, result.FaultResult);
            }

            return Ok(result.SuceedResult);
        }
    }
}
