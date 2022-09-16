using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos.Products;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FNS.Presentation.Controllers.Products
{
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(ProblemResultInfo), StatusCodes.Status500InternalServerError, MediaTypeNames.Application.Json)]
    public sealed partial class ProductsController
    {
        [ProducesResponseType(typeof(IEnumerable<ProductDto>), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        public partial IActionResult GetAll();

        [ProducesResponseType(typeof(IEnumerable<ProductDto>), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        public partial IActionResult GetProductsByCategoryId(string subCategoryId);

        [ProducesResponseType(typeof(ProductWithAdditionalInfoDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ProblemResultInfo), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> GetWithAdditionalInfoAsync(string id);

        [ProducesResponseType(typeof(EmptyResult), StatusCodes.Status401Unauthorized, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(EmptyResult), StatusCodes.Status403Forbidden, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ProductWithAdditionalInfoDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ProblemResultInfo), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> CreateAsync(ProductForCreateDto dto);

        [ProducesResponseType(typeof(EmptyResult), StatusCodes.Status401Unauthorized, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(EmptyResult), StatusCodes.Status403Forbidden, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ProductWithAdditionalInfoDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ProblemResultInfo), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> UpdateAsync(ProductWithAdditionalInfoDto dto);

        [ProducesResponseType(typeof(EmptyResult), StatusCodes.Status401Unauthorized, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(EmptyResult), StatusCodes.Status403Forbidden, MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public partial Task<IActionResult> DeleteAsync(string id);

        [ProducesResponseType(typeof(EmptyResult), StatusCodes.Status401Unauthorized, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(EmptyResult), StatusCodes.Status403Forbidden, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(UnsavedFilesInfoDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> LoadProductsFromJsonFile(IFormFile file, IWebHostEnvironment env);
    }
}
