using NodaTime;

namespace FNS.Services.Dtos.SalesReceipts
{
    public sealed class SalesReceiptDto
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public Instant CreatedAt { get; set; }
    }
}
