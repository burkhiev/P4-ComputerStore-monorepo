using System.Security.Claims;
using FNS.Services.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FNS.Presentation.Utilities.Auth
{
    public sealed class UserActivityCheckerAttribute : Attribute, IAsyncAuthorizationFilter
    {
        private readonly IRootService _rootService;

        public UserActivityCheckerAttribute(IRootService rootService)
        {
            _rootService = rootService; // TODO: дописать
        }

        public IRootService RootService => _rootService;

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            var userId = context.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
