using FNS.Domain.Models.Products;

namespace FNS.Domain.Models.SalesReceipts
{
    public sealed class SalesReceiptWithProduct : EntityBase
    {
        public string SalesReceiptId { get; set; }
        public SalesReceipt SalesReceipt { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
