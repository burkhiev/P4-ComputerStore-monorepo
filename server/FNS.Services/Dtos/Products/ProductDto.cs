namespace FNS.Services.Dtos.Products
{
    public sealed class ProductDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public decimal Price { get; set; }
        public string SubCategoryId { get; set; }
    }
}
