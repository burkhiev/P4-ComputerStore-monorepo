using System.Diagnostics.CodeAnalysis;

namespace FNS.Domain.Utilities.OperationResults
{
    public class AppOperationResult<TSucceededResult>
    {
        public AppOperationResult()
        {

        }

        public AppOperationResult(TSucceededResult succeedResult)
        {
            SucceedResult = succeedResult;
        }

        [MemberNotNullWhen(true, nameof(FaultResult))]
        public bool IsFaulted => FaultResult is not null;

        public bool IsSucceeded => FaultResult is null;

        public AppProblemDetails? FaultResult { get; set; }

        public TSucceededResult? SucceedResult { get; set; }
    }
}
