using Microsoft.AspNetCore.Http;

namespace FNS.Domain.Utilities.OperationResults
{
    public sealed class EntityNotFoundOpResult<T> : AppOpResult<T>
    {
        public EntityNotFoundOpResult() : base()
        {
            FaultResult = new AppProblemDetails
            {
                Title = $"{nameof(T)} entity not found",
                Detail = $"{nameof(T)} entity with specified Id is not found.",
                StatusCode = StatusCodes.Status404NotFound,
            };
        }
    }
}
