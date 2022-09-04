using System.Diagnostics.CodeAnalysis;

namespace FNS.Domain.Utilities.OperationResults
{
    public class AppOpResult<TSucceededResult>
    {
        public AppOpResult()
        {
            // do nothing
        }

        public AppOpResult(TSucceededResult succeedResult)
        {
            SuceedResult = succeedResult;
        }

        [MemberNotNullWhen(true, nameof(FaultResult))]
        public bool IsFaulted => FaultResult is not null;

        public bool IsSucceeded => FaultResult is null;

        public AppProblemDetails? FaultResult { get; set; }

        public TSucceededResult? SuceedResult { get; set; }
    }
}
