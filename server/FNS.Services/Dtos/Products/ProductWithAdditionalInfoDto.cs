namespace FNS.Services.Dtos.Products
{
    public sealed class ProductWithAdditionalInfoDto : DtoBase
    {
        public uint ConcurrencyToken { get; set; }
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public decimal Price { get; set; }
        public string SubCategoryId { get; set; }
        public Dictionary<string, dynamic?> AdditionalAttributes { get; set; }
    }
}
