using System.Dynamic;

namespace FNS.Services.Dtos.Products
{
    public sealed class ProductForCreateDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string ProductCode { get; set; }
        public decimal Price { get; set; }
        public string SubCategoryId { get; set; }
        public Dictionary<string, object?> AdditionalAttributes { get; set; } // Id атрибута и значение (может иметь базовый тип)
    }
}
