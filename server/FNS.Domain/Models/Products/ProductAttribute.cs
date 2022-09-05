namespace FNS.Domain.Models.Products
{
    public sealed class ProductAttribute : EntityBase
    {
        public string Name { get; set; }
        public string ClrType { get; set; }
        public string? Measure { get; set; }
        public List<ProductAttributeValue>? ProductAttributeValues { get; set; }
    }
}
