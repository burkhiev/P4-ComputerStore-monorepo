using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace FNS.Domain.Utilities.OperationResults
{
    public sealed class InvalidDbConcurrencyUpdateOpResult<T> : AppOpResult<T>
    {
        public InvalidDbConcurrencyUpdateOpResult() : base()
        {
            FaultResult = new AppProblemDetails
            {
                Title = "Concurrency update error",
                Detail = "Error occurred because many people tried update one record. Please, try again.",
                StatusCode = StatusCodes.Status400BadRequest,
            };
        }
    }
}
