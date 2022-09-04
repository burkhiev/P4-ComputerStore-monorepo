namespace FNS.Services.Dtos.Products
{
    public sealed class ProductAttributeDto
    {
        public string Id { get; set; }
        public uint ConcurrencyToken { get; set; }
        public string Name { get; set; }
        public string ClrType { get; set; }
        public string? Measure { get; set; }
    }
}
