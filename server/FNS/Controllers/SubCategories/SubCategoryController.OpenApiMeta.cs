using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos;
using FNS.Services.Dtos.Products;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FNS.Presentation.Controllers.SubCategories
{
    [ProducesResponseType(typeof(EmptyResult), StatusCodes.Status401Unauthorized, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(EmptyResult), StatusCodes.Status403Forbidden, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(ProblemResultInfo), StatusCodes.Status500InternalServerError, MediaTypeNames.Application.Json)]
    public sealed partial class SubCategoryController
    {
        [ProducesResponseType(typeof(IEnumerable<SubCategoryDto>), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        public partial IActionResult GetAll();

        [ProducesResponseType(typeof(SubCategoryDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ProblemResultInfo), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> CreateAsync(SubCategoryForCreateDto dto);

        [ProducesResponseType(typeof(SubCategoryDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ProblemResultInfo), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> UpdateAsync(SubCategoryDto dto);

        [ProducesResponseType(typeof(SubCategoryDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ProblemResultInfo), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> DeleteAsync(string id);
    }
}
