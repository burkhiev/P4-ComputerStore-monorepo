using NodaTime;

namespace FNS.Domain.Models
{
    public abstract class EntityBase : IEntityBase
    {
        public string Id { get; set; }
        public uint xmin { get; set; }
        public Instant CreatedAt { get; set; }
        public Instant UpdatedAt { get; set; }
    }
}
