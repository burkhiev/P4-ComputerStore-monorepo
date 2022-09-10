using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using FNS.Domain.Exceptions;
using FNS.Domain.Models.Identity;
using FNS.Domain.Utilities.OperationResults;
using FNS.Presentation.Utilities.Auth;
using FNS.Services.Abstractions;
using FNS.Services.Dtos.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FNS.Presentation.Controllers.Identity
{
    [ApiController]
    [Route("api/accounts")]
    public sealed partial class LoginController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IRootService _rootService;

        public LoginController(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            IRootService rootService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _rootService = rootService;
        }

        public SignInManager<User> SignInManager => _signInManager;
        public UserManager<User> UserManager => _userManager;
        public IRootService RootService => _rootService;

        [HttpPost("register")]
        public partial async Task<IActionResult> RegisterAsync([FromBody] RegisterDto dto)
        {
            var result = await RootService.UserService.CreateUserAsync(UserManager, dto);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return Ok(result.SucceedResult);
        }

        private async Task<IEnumerable<Claim>?> GetClaimsAsync(User user)
        {
            var roles = await UserManager.GetRolesAsync(user);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.Email),
            };

            foreach(var role in roles)
            {
                if(role is not null)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }
            }

            return claims;
        }

        [HttpPost("login")]
        public partial async Task<IActionResult> Login(LoginDto dto)
        {
            var user = await UserManager.FindByEmailAsync(dto.Email);

            if(user is null)
            {
                var problem = new LoginProblemDetails();
                return Unauthorized(problem);
            }


            var claims = await GetClaimsAsync(user);

            if(claims is null)
            {
                var problem = new LoginProblemDetails();
                return Unauthorized(problem);
            }


            var now = DateTime.UtcNow;

            var jwt = new JwtSecurityToken(
                issuer: JwtAuthenticateOptions.Issuer,
                audience: JwtAuthenticateOptions.Audience,
                claims: claims,
                notBefore: now,
                expires: now.AddMinutes(JwtAuthenticateOptions.LifetimeMinutes),
                signingCredentials: JwtAuthenticateOptions.CreateSigningCredentials());

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.WriteToken(jwt);


            var response = new SuccessLoginDto { AccessToken = token };
            return Ok(response);
        }

        [HttpDelete("{userId}")]
        [Authorize]
        public partial async Task<IActionResult> Delete([FromRoute] string userId, [FromBody] UserDeletingDto dto)
        {
            string? identityId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if(string.IsNullOrWhiteSpace(userId) || userId != dto.Id || userId != identityId)
            {
                return BadRequest();
            }

            var result = await RootService.UserService.DeleteUserAsync(UserManager, dto);

            if(result.IsFailed)
            {
                return StatusCode(result.FailResult.StatusCode, result.FailResult);
            }

            return NoContent();
        }

        private sealed class LoginProblemDetails : ProblemResultInfo
        {
            public LoginProblemDetails()
            {
                Title = "Login action failed";
                Detail = "Invalid email or password.";
                StatusCode = StatusCodes.Status401Unauthorized;
            }
        }
    }
}
