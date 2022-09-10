using NodaTime;

namespace FNS.Domain.Models.Products
{
    public class ProductAttribute : EntityBase
    {
        public string Name { get; set; }
        public string ClrType { get; set; }
        public string? Measure { get; set; }
        public Instant CreatedAt { get; set; }
        public virtual List<ProductAttributeValue>? ProductAttributeValues { get; set; }
    }
}
