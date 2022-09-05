using FNS.Domain.Models.Identity;
using NodaTime;

namespace FNS.Domain.Models.SalesReceipts
{
    public sealed class SalesReceipt : EntityBase
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public Instant CreatedAt { get; set; }
        public List<SalesReceiptWithProduct>? SalesReceiptsWithProducts{ get; set; }
    }
}
