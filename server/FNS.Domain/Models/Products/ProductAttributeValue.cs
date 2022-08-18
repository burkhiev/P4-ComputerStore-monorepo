namespace FNS.Domain.Models.Products
{
    public sealed class ProductAttributeValue : EntityBase
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid ProductAttributeId { get; set; }
        public ProductAttribute ProductAttribute { get; set; }
        public string? Value { get; set; }
    }
}
