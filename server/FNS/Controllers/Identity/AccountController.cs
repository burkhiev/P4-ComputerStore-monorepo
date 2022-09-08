using System.IdentityModel.Tokens.Jwt;
using System.Net.Mime;
using System.Security.Claims;
using FNS.Domain.Models.Identity;
using FNS.Domain.Utilities.OperationResults;
using FNS.Presentation.Utilities.Auth;
using FNS.Services.Dtos.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FNS.Presentation.Controllers.Identity
{
    [ApiController]
    [Route("api/accounts")]
    public sealed partial class AccountController : ControllerBase
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

        [HttpPost("login")]
        public partial async Task<IActionResult> Login(LoginDto dto)
        {
            await SignInManager.SignOutAsync();

            var user = await UserManager.FindByEmailAsync(dto.Email);

            if(user is null)
            {
                var problem = new LoginProblemDetails();
                return Unauthorized(problem);
            }


            var result = await SignInManager.PasswordSignInAsync(
                user: user, 
                password: dto.Password, 
                isPersistent: true,
                lockoutOnFailure: false);

            if(!result.Succeeded)
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
                expires: now.AddSeconds(JwtAuthenticateOptions.LifetimeSeconds),
                signingCredentials: JwtAuthenticateOptions.CreateSigningCredentials());

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.WriteToken(jwt);


            var response = new SuccessLoginDto { AccessToken = token };
            return Ok(response);
        }

        [HttpPost("logout")]
        [Authorize]
        public partial async Task<IActionResult> Logout()
        {
            await SignInManager.SignOutAsync();
            return NoContent();
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
