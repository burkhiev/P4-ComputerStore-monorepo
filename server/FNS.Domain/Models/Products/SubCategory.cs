namespace FNS.Domain.Models.Products
{
    public sealed class SubCategory : EntityBase
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
