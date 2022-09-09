using FNS.Domain.Models.Products;

namespace FNS.Domain.Models.Purchases
{
    public class PurchaseInvoiceItem : EntityBase
    {
        public string PurchaseInvoiceId { get; set; }
        public virtual PurchaseInvoice PurchaseInvoice { get; set; }
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Amount { get; set; }
    }
}
