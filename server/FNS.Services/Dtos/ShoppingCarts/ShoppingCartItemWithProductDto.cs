using FNS.Services.Dtos.Products;

namespace FNS.Services.Dtos.ShoppingCarts
{
    public sealed class ShoppingCartItemWithProductDto
    {
        public string Id { get; set; }
        public string ShoppingCartId { get; set; }
        public ProductDto Product { get; set; }
        public int Amount { get; set; } = 0;
    }
}
