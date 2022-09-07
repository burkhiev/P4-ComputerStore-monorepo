using System.IdentityModel.Tokens.Jwt;
using System.Net.Mime;
using System.Security.Claims;
using FNS.Domain.Models.Identity;
using FNS.Domain.Utilities.OperationResults;
using FNS.Presentation.Utilities.Auth;
using FNS.Services.Dtos.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FNS.Presentation.Controllers
{
    [ApiController]
    [Route("api/accounts")]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest, MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status500InternalServerError, MediaTypeNames.Application.Json)]
    public sealed class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public SignInManager<User> SignInManager => _signInManager;
        public UserManager<User> UserManager => _userManager;

        [HttpPost("token")]
        [ProducesResponseType(typeof(SuccessLoginDto), StatusCodes.Status200OK, MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AppProblemDetails), StatusCodes.Status401Unauthorized, MediaTypeNames.Application.Json)]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var claims = await GetIdentityAsync(dto.Email);

            if(claims is null)
            {
                var badResult = new LoginProblemDetails();
                return Unauthorized(badResult);
            }

            
            var now = DateTime.UtcNow;

            var jwt = new JwtSecurityToken(
                issuer: JwtAuthenticateOptions.Issuer,
                audience: JwtAuthenticateOptions.Audience,
                claims: claims,
                notBefore: now,
                expires: now.AddSeconds(JwtAuthenticateOptions.LifetimeSeconds),
                signingCredentials: JwtAuthenticateOptions.CreateSigningCredentials());

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.WriteToken(jwt);


            var response = new SuccessLoginDto { AccessToken = token };
            return Ok(response);
        }

        private async Task<IEnumerable<Claim>?> GetIdentityAsync(string email)
        {
            var user = await UserManager.FindByEmailAsync(email);

            if(user is null)
            {
                return null;
            }

            var roles = await UserManager.GetRolesAsync(user);

            var claims = new List<Claim>
            {
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

        private sealed class LoginProblemDetails : AppProblemDetails
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
