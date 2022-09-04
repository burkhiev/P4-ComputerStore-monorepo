using FNS.Domain.Models.Products;

namespace FNS.Domain.Models.Purchases
{
    public sealed class PurchaseInvoiceItem : EntityBase
    {
        public string PurchaseInvoiceId { get; set; }
        public PurchaseInvoice PurchaseInvoice { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
