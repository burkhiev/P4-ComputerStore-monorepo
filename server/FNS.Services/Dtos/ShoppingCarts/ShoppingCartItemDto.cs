using NodaTime;

namespace FNS.Services.Dtos.ShoppingCarts
{
    public sealed class ShoppingCartItemDto
    {
        public string Id { get; set; }
        public Instant CreatedAt { get; set; }
        public int Amount { get; set; }
    }
}
