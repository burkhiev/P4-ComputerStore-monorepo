using Microsoft.AspNetCore.Http;

namespace FNS.Domain.Utilities.OperationResults
{
    public class ProblemResultInfo
    {
        public string Title { get; set; } = string.Empty;
        public string Detail { get; set; } = string.Empty;
        public int StatusCode { get; set; } = StatusCodes.Status500InternalServerError;
        public IDictionary<string, string>? Errors { get; set; }
    }
}
