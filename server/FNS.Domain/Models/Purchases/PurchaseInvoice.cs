using FNS.Domain.Models.Identity;
using NodaTime;

namespace FNS.Domain.Models.Purchases
{
    public class PurchaseInvoice : EntityBase
    {
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public Instant CreatedAt { get; set; }
        public virtual List<PurchaseInvoiceItem>? PurchaseInvoiceItems { get; set; }
    }
}
