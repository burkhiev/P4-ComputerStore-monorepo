using Microsoft.AspNetCore.Http;

namespace FNS.Domain.Utilities.OperationResults
{
    public sealed class BadRequestResult<T>: OpResult<T>
    {
        public BadRequestResult() : base()
        {
            FailResult = new ProblemResultInfo
            {
                Title = "Bad request",
                Detail = "Invalid data received.",
                StatusCode = StatusCodes.Status400BadRequest,
            };
        }
    }
}
