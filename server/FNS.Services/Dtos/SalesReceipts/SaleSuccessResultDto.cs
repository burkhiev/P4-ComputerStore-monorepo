using NodaTime;

namespace FNS.Services.Dtos.SalesReceipts
{
    public sealed class SaleSuccessResultDto
    {
        public string UserId { get; set; }
        public Instant DateOfSale { get; set; }
    }
}
