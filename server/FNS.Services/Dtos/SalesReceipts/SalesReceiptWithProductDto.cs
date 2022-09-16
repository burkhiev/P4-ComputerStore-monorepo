using FNS.Services.Dtos.Products;

namespace FNS.Services.Dtos.SalesReceipts
{
    public sealed class SalesReceiptWithProductDto
    {
        public string Id { get; set; }
        public string SalesReceiptId { get; set; }
        public ProductDto Product { get; set; }
        public int Amount { get; set; }
    }
}
