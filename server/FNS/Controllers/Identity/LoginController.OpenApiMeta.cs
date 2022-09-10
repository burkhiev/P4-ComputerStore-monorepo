using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace FNS.Presentation.Controllers.Identity
{
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(ProblemResultInfo), StatusCodes.Status500InternalServerError, MediaTypeNames.Application.Json)]
    public partial class LoginController
    {
        [ProducesResponseType(typeof(SuccessLoginDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ProblemResultInfo), StatusCodes.Status401Unauthorized, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> Login(LoginDto dto);

        [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ProblemResultInfo), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> RegisterAsync(RegisterDto dto);

        [ProducesResponseType(typeof(UserDto), StatusCodes.Status204NoContent, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ProblemResultInfo), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
        public partial Task<IActionResult> Delete(string userId, UserDeletingDto dto);
    }
}
