using NodaTime;

namespace FNS.Domain.Models.Products
{
    public class ProductAttributeValue : EntityBase
    {
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }
        public string ProductAttributeId { get; set; }
        public virtual ProductAttribute ProductAttribute { get; set; }
        public string? Value { get; set; }
    }
}
