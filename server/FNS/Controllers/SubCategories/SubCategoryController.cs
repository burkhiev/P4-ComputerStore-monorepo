using FNS.Services.Abstractions;
using FNS.Services.Dtos.Products;
using FNS.Services.Utils.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FNS.Presentation.Controllers.SubCategories
{
    [Authorize(Roles = AppRoleNames.Admin)]
    [ApiController]
    [Route("api/sub-cat")]
    public sealed partial class SubCategoryController : ControllerBase
    {
        private readonly IRootService _rootService;

        public SubCategoryController(IRootService rootService)
        {
            _rootService = rootService;
        }

        public IRootService RootService => _rootService;

        [HttpGet]
        public partial IActionResult GetAll()
        {
            var result = RootService.ProductsService.GetAllSubCategories();

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [HttpPost]
        public partial async Task<IActionResult> CreateAsync(SubCategoryForCreateDto dto)
        {
            var result = await RootService.ProductsService.CreateSubCategoryAsync(dto);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [HttpPut]
        public partial async Task<IActionResult> UpdateAsync(SubCategoryDto dto)
        {
            var result = await RootService.ProductsService.UpdateSubCategoryAsync(dto);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        [HttpDelete("{id}")]
        public partial async Task<IActionResult> DeleteAsync(string id)
        {
            var result = await RootService.ProductsService.DeleteSubCategoryAsync(id);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }
    }
}
