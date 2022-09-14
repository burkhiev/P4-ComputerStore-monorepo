namespace FNS.Services.Dtos.ShoppingCarts
{
    public sealed class ShoppingCartForChangeItemAmountDto
    {
        public string UserId { get; set; }
        public string ItemId { get; set; }
        public int Amount { get; set; }
    }
}
