using NodaTime;

namespace FNS.Domain.Models
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }
        public Instant CreatedAt { get; set; }
        public Instant UpdatedAt { get; set; }
        public bool Tumbstone { get; set; }
    }
}
