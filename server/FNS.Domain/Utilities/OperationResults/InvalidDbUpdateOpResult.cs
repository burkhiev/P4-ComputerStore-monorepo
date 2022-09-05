using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace FNS.Domain.Utilities.OperationResults
{
    public sealed class InvalidDbUpdateOpResult<T> : AppOpResult<T>
    {
        public InvalidDbUpdateOpResult() : base()
        {
            FaultResult = new AppProblemDetails
            {
                Title = "Update error",
                Detail = "Unexpected error occurred. One of the cause is invalid entity Id.",
                StatusCode = StatusCodes.Status400BadRequest,
            };
        }
    }
}
