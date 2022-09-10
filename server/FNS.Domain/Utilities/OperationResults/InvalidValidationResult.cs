using Microsoft.AspNetCore.Http;

namespace FNS.Domain.Utilities.OperationResults
{
    public sealed class InvalidValidationResult<TSucceedResult> : OpResult<TSucceedResult>
    {
        public InvalidValidationResult() : base()
        {
            FailResult = new ProblemResultInfo
            {
                Title = "Validation error",
                Detail = "One or more validation errors occurred.",
                StatusCode = StatusCodes.Status400BadRequest,
            };
        }
    }
}
