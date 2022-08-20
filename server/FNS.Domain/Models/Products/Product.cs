namespace FNS.Domain.Models.Products
{
    public sealed class Product : EntityBase
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string ProductCode { get; set; }
        public decimal Price { get; set; }
        //public Category Category { get; set; }
        //public Guid CategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public Guid SubCategoryId { get; set; }
        //public List<Price> AllPrices { get; set; }
        public List<ProductAttributeValue> ProductAttributeValues { get; set; }
    }
}
