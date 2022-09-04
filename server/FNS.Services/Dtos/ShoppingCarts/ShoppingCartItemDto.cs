using FNS.Services.Dtos.Products;

namespace FNS.Services.Dtos.ShoppingCarts
{
    public sealed class ShoppingCartItemDto : DtoBase
    {
        public string ShoppingCartId { get; set; }
        public ProductDto Product { get; set; }
        public int Amount { get; set; } = 0;
    }
}
