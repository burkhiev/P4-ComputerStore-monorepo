using Microsoft.AspNetCore.Http;

namespace FNS.Domain.Utilities.OperationResults
{
    public sealed class InvalidDbUpdateResult<T> : OpResult<T>
    {
        public InvalidDbUpdateResult() : base()
        {
            FailResult = new ProblemResultInfo
            {
                Title = "Update error",
                Detail = "Unexpected error occurred. One of the cause is invalid entity Id.",
                StatusCode = StatusCodes.Status400BadRequest,
            };
        }
    }
}
