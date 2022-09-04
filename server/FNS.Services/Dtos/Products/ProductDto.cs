namespace FNS.Services.Dtos.Products
{
    public sealed class ProductDto : DtoBase
    {
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public decimal Price { get; set; }
        public string SubCategoryId { get; set; }
    }
}
