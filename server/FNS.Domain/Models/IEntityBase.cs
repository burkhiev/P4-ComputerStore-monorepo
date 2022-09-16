using NodaTime;

namespace FNS.Domain.Models
{
    public interface IEntityBase
    {
        string Id { get; set; }
        public uint xmin { get; set; }
        Instant CreatedAt { get; set; }
        Instant UpdatedAt { get; set; }
    }
}