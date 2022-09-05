namespace FNS.Domain.Models
{
    public abstract class EntityBase : IEntityBase
    {
        public string Id { get; set; }
        public uint xmin { get; set; }
    }
}
