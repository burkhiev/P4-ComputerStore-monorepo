using NodaTime;

namespace FNS.Domain.Models
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }
        public Instant AddedAt { get; set; }
    }
}
