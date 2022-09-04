using FNS.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace FNS.Presentation.Controllers
{
    [Route("api/sales")]
    [ApiController]
    public sealed class SalesController : ControllerBase
    {
        private readonly IRootService _rootService;

        public SalesController(IRootService rootService)
        {
            _rootService = rootService;
        }

        public IRootService RootService => _rootService;

        [HttpGet]
        public IActionResult Get()
        {
            var result = RootService.SalesReceiptService.GetAll();

            if(result.IsFaulted)
            {
                return StatusCode(result.ProblemDetails.StatusCode, result.ProblemDetails);
            }

            return Ok(result.Result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var result = await RootService.SalesReceiptService.GetWithAdditionalAsync(id);

            if(result.IsFaulted)
            {
                return StatusCode(result.ProblemDetails.StatusCode, result.ProblemDetails);
            }

            return Ok(result.Result);
        }
    }
}
