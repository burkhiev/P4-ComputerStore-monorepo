namespace FNS.Domain.Models.Products
{
    public class ProductAttributeGroup : EntityBase
    {
        public string Name { get; set; }
        public List<ProductAttribute> ProductAttributes { get; set; }
    }
}
