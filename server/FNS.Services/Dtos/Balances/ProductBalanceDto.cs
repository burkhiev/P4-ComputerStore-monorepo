namespace FNS.Services.Dtos.Balances
{
    public sealed class ProductBalanceDto : DtoBase
    {
        public string ProductId { get; set; }
        public int Amount { get; set; }
    }
}
