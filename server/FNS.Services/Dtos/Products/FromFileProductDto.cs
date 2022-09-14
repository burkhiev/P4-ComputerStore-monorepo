namespace FNS.Services.Dtos.Products
{
    public sealed class FromFileProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductCode { get; set; }
        public decimal Price { get; set; }
        public string SubCategoryName { get; set; }
        public List<FromFileCharacteristicDto> OwnAttributes { get; set; }
    }
}
