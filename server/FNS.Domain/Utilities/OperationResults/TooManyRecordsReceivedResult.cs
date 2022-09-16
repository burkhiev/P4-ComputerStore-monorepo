using Microsoft.AspNetCore.Http;

namespace FNS.Domain.Utilities.OperationResults
{
    public sealed class TooManyRecordsReceivedResult<T> : OpResult<T>
    {
        public TooManyRecordsReceivedResult(int maxCount) : base()
        {
            FailResult = new ProblemResultInfo
            {
                Title = "Too many records was received",
                Detail = $"Too many records was received. Max records count: {maxCount}",
                StatusCode = StatusCodes.Status400BadRequest
            };
        }
    }
}
