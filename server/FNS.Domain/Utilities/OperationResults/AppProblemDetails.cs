namespace FNS.Domain.Utilities.OperationResults
{
    public class AppProblemDetails
    {
        public string Title { get; set; } = string.Empty;
        public string Detail { get; set; } = string.Empty;
        public int StatusCode { get; set; }
    }
}
