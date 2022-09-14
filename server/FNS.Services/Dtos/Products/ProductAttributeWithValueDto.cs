namespace FNS.Services.Dtos.Products
{
    public sealed class ProductAttributeWithValueDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string GroupName { get; set; }
        public dynamic? Value { get; set; }
    }
}
