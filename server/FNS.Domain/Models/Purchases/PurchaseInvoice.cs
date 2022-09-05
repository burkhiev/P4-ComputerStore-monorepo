using FNS.Domain.Models.Identity;

namespace FNS.Domain.Models.Purchases
{
    public sealed class PurchaseInvoice : EntityBase
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public List<PurchaseInvoiceItem>? PurchaseInvoiceItems { get; set; }
    }
}
