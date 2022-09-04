using FNS.Domain.Models.Products;

namespace FNS.Domain.Models.ShoppingCarts
{
    public sealed class ShoppingCartItem : EntityBase
    {
        public string ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
