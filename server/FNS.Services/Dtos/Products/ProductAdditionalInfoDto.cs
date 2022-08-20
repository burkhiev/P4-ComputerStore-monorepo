namespace FNS.Services.Dtos.Products
{
    public sealed class ProductAdditionalInfoDto
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public string ProductCode { get; set; }
        public dynamic[] Attributes { get; set; }
    }
}
