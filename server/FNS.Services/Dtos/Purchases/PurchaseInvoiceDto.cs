using NodaTime;

namespace FNS.Services.Dtos.Purchases
{
    public sealed class PurchaseInvoiceDto
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public Instant CreatedAt { get; set; }
    }
}
