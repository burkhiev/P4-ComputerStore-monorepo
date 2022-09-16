using FNS.Domain.Models.Products;

namespace FNS.Domain.Models.SalesReceipts
{
    public class SalesReceiptWithProduct : EntityBase
    {
        public string SalesReceiptId { get; set; }
        public virtual SalesReceipt SalesReceipt { get; set; }
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Amount { get; set; }
    }
}
