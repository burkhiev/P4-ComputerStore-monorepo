using FNS.Domain.Models.Identity;

namespace FNS.Domain.Models.ShoppingCarts
{
    public class ShoppingCart : EntityBase
    {
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public virtual List<ShoppingCartItem>? ShoppingCartItems { get; set; }
    }
}
