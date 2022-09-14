namespace FNS.Domain.Models.Products
{
    public class ProductAttribute : EntityBase
    {
        public string Name { get; set; }
        public string ClrType { get; set; }
        public string GroupId { get; set; }
        public ProductAttributeGroup Group { get; set; }
        public virtual List<ProductAttributeValue>? ProductAttributeValues { get; set; }
    }
}
