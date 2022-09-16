using NodaTime;

namespace FNS.Services.Dtos.Purchases
{
    public sealed class PurchaseInvoiceWithAdditionalInfoDto
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public Instant CreatedAt { get; set; }
        public List<PurchaseInvoiceItemDto> Items { get; set; }
    }
}
