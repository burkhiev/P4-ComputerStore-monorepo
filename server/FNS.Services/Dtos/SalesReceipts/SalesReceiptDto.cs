using NodaTime;

namespace FNS.Services.Dtos.SalesReceipts
{
    public sealed class SalesReceiptDto : DtoBase
    {
        public string UserId { get; set; }
        public Instant CreatedAt { get; set; }
    }
}
