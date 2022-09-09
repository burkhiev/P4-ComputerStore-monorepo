using FNS.Domain.Models.Identity;
using NodaTime;

namespace FNS.Domain.Models.SalesReceipts
{
    public class SalesReceipt : EntityBase
    {
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public Instant CreatedAt { get; set; }
        public virtual List<SalesReceiptWithProduct>? SalesReceiptsWithProducts{ get; set; }
    }
}
