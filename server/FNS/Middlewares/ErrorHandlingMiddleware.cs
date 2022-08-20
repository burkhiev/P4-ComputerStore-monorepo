using FNS.Domain.Utilities.OperationResults;
using System.Net.Mime;

namespace FNS.Presentation.Middlewares
{
    public class ErrorHandlingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch(Exception)
            {
                var problemDetails = new AppProblemDetails
                {
                    Title = "Unknown error",
                    Detail = "Something went wrong.",
                    StatusCode = StatusCodes.Status500InternalServerError,
                };

                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Response.ContentType = MediaTypeNames.Application.Json;
                await context.Response.WriteAsJsonAsync(problemDetails);
            }
        }
    }
}
