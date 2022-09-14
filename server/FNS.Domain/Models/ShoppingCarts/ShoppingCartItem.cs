using FNS.Domain.Models.Products;
using NodaTime;

namespace FNS.Domain.Models.ShoppingCarts
{
    public class ShoppingCartItem : EntityBase
    {
        public string ShoppingCartId { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Amount { get; set; }
    }
}
