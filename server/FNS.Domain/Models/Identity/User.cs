using FNS.Domain.Models.Purchases;
using FNS.Domain.Models.SalesReceipts;
using FNS.Domain.Models.ShoppingCarts;
using Microsoft.AspNetCore.Identity;

namespace FNS.Domain.Models.Identity
{
    public sealed class User : IdentityUser, IEntityBase
    {
        public uint xmin { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public List<SalesReceipt>? SalesReceipts { get; set; }
        public List<PurchaseInvoice>? PurchaseInvoices { get; set; }
    }
}
