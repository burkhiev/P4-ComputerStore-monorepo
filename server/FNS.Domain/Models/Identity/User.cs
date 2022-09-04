using FNS.Domain.Models.SalesReceipts;
using FNS.Domain.Models.ShoppingCarts;
using Microsoft.AspNetCore.Identity;

namespace FNS.Domain.Models.Identity
{
    public sealed class User : IdentityUser, IEntityBase
    {
        public uint ConcurrencyToken { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public SalesReceipt SalesReceipt { get; set; }
    }
}
