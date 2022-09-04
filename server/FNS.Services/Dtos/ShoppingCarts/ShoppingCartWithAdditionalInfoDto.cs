using FNS.Services.Dtos.Identity;

namespace FNS.Services.Dtos.ShoppingCarts
{
    public sealed class ShoppingCartWithAdditionalInfoDto : DtoBase
    {
        public uint ConcurrencyToken { get; set; }
        public string UserId { get; set; }
        public List<ShoppingCartItemDto> ShoppingCartItems { get; set; }
    }
}
