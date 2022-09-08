using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos;
using FNS.Services.Dtos.ShoppingCarts;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FNS.Presentation.Controllers.ShoppingCarts
{
    [ProducesResponseType(typeof(EmptyDto), StatusCodes.Status401Unauthorized, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status500InternalServerError, MediaTypeNames.Application.Json)]
    public partial class ShoppingCartsController
    {
        [ProducesResponseType(typeof(EmptyDto), StatusCodes.Status403Forbidden, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(IEnumerable<ShoppingCartDto>), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        public partial IActionResult GetAll();

        [ProducesResponseType(typeof(ShoppingCartWithAdditionalInfoDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> GetByUserIdWithAdditionalInfoAsync(string userId);

        [ProducesResponseType(typeof(EmptyDto), StatusCodes.Status204NoContent, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> AddCartItemAsync(string userId, ShoppingCartItemForCreateDto dto);

        [ProducesResponseType(typeof(ShoppingCartForChangeItemAmountDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status404NotFound, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> UpdateCartItemAmountAsync(string userId, ShoppingCartForChangeItemAmountDto dto);

        [ProducesResponseType(typeof(EmptyDto), StatusCodes.Status204NoContent, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> DeleteCartItemAsync(string userId, string itemId);
    }
}

