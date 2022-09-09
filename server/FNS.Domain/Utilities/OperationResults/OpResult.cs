using System.Diagnostics.CodeAnalysis;

namespace FNS.Domain.Utilities.OperationResults
{
    public class OpResult<TSucceededResult>
    {
        public OpResult()
        {
            // do nothing
        }

        public OpResult(TSucceededResult succeedResult)
        {
            SucceedResult = succeedResult;
        }

        [MemberNotNullWhen(true, nameof(FailResult))]
        public bool Failed => FailResult is not null;

        public bool Succeeded => FailResult is null;

        public ProblemResultInfo? FailResult { get; set; }

        public TSucceededResult? SucceedResult { get; set; }
    }
}
