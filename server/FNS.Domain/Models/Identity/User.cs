using FNS.Domain.Models.Purchases;
using FNS.Domain.Models.SalesReceipts;
using FNS.Domain.Models.ShoppingCarts;
using Microsoft.AspNetCore.Identity;
using NodaTime;

namespace FNS.Domain.Models.Identity
{
    public class User : IdentityUser, IEntityBase
    {
        public uint xmin { get; set; }
        public Instant CreatedAt { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
        public virtual List<SalesReceipt>? SalesReceipts { get; set; }
        public virtual List<PurchaseInvoice>? PurchaseInvoices { get; set; }
        public virtual List<IdentityUserRole<string>>? UserRoles { get; set; }
    }
}
