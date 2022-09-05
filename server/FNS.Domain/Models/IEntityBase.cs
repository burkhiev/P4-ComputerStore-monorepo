namespace FNS.Domain.Models
{
    public interface IEntityBase
    {
        string Id { get; set; }
        public uint xmin { get; set; }
    }
}