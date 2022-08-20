namespace FNS.Domain.Exceptions
{
    public sealed class EntityNotFoundException : Exception
    {
        public EntityNotFoundException()
            : base("Entity is not found")
        {

        }
    }
}
