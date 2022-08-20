using FNS.Presentation.Middlewares;

namespace FNS.Presentation.Utilities.ExtensionMethods
{
    public static class ErrorHandlingExtensions
    {
        public static IApplicationBuilder UseGlobalErrorHandler(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<ErrorHandlingMiddleware>();
            return builder;
        }
    }
}
