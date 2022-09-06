namespace FNS.Services.Dtos.ShoppingCarts
{
    public sealed class ShoppingCartForChangeItemAmountDto
    {
        public string ItemId { get; set; }
        public uint ConcurrencyToken { get; set; }
        public int Amount { get; set; }
    }
}
