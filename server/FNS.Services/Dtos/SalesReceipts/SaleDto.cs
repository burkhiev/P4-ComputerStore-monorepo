namespace FNS.Services.Dtos.SalesReceipts
{
    public sealed class SaleDto
    {
        public string UserId { get; set; }
        public List<ProductSaleDto> ProductsInfo { get; set; }
    }
}
