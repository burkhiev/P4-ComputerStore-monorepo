namespace FNS.Domain.Models.Products
{
    public sealed class ProductAttribute : EntityBase
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string? Measure { get; set; }
    }
}
