using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos.Products;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FNS.Presentation.Controllers.Products
{
    [ProducesResponseType(typeof(EmptyResult), StatusCodes.Status401Unauthorized, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(EmptyResult), StatusCodes.Status403Forbidden, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status500InternalServerError, MediaTypeNames.Application.Json)]
    public partial class ProductAttributeController
    {
        [ProducesResponseType(typeof(IEnumerable<ProductAttributeDto>), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        public partial IActionResult GetAll();

        [ProducesResponseType(typeof(ProductAttributeDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> CreateAsync(ProductAttributeForCreateDto dto);

        [ProducesResponseType(typeof(ProductAttributeDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> UpdateAsync(ProductAttributeDto dto);

        [ProducesResponseType(typeof(ProductAttributeDto), StatusCodes.Status204NoContent, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> DeleteAsync(string id);
    }
}
