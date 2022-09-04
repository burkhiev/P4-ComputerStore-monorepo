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
            Result = succeedResult;
        }

        [MemberNotNullWhen(true, nameof(ProblemDetails))]
        public bool IsFaulted => ProblemDetails is not null;

        public bool IsSucceeded => ProblemDetails is null;

        public AppProblemDetails? ProblemDetails { get; set; }

        public TSucceededResult? Result { get; set; }
    }
}
