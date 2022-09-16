using FNS.Services.Dtos.Identity;

namespace FNS.Services.Dtos.ShoppingCarts
{
    public sealed class ShoppingCartWithAdditionalInfoDto
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public List<ShoppingCartItemWithProductDto> ShoppingCartItems { get; set; }
    }
}
