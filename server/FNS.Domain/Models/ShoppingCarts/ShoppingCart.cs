using FNS.Domain.Models.Identity;

namespace FNS.Domain.Models.ShoppingCarts
{
    public sealed class ShoppingCart : EntityBase
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public List<ShoppingCartItem>? ShoppingCartItems { get; set; }
    }
}
