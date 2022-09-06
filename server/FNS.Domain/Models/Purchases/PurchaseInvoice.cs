using FNS.Domain.Models.Identity;
using NodaTime;

namespace FNS.Domain.Models.Purchases
{
    public sealed class PurchaseInvoice : EntityBase
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public Instant CreatedAt { get; set; }
        public List<PurchaseInvoiceItem>? PurchaseInvoiceItems { get; set; }
    }
}
