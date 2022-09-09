using Microsoft.AspNetCore.Http;

namespace FNS.Domain.Utilities.OperationResults
{
    public sealed class InvalidDbConcurrencyUpdateResult<T> : OpResult<T>
    {
        public InvalidDbConcurrencyUpdateResult() : base()
        {
            FailResult = new ProblemResultInfo
            {
                Title = "Concurrency update error",
                Detail = "Error occurred because many people tried update one record. Please, try again.",
                StatusCode = StatusCodes.Status400BadRequest,
            };
        }
    }
}
