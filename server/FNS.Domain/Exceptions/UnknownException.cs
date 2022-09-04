namespace FNS.Domain.Exceptions
{
    public sealed class UnknownException : Exception
    {
        public UnknownException() : base("The unexpected program behavior is detected.")
        {

        }
    }
}
