using FNS.Domain.Models.Products;

namespace FNS.Services.Dtos.Products
{
    public sealed class ProductAttributeValueDto
    {
        public string Name { get; set; }
        public string TSType { get; set; }
        public string? Value { get; set; }
        public string? Measure { get; set; }
    }
}
