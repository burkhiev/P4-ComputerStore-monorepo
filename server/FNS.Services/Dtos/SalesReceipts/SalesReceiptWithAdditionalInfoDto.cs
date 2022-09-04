using NodaTime;

namespace FNS.Services.Dtos.SalesReceipts
{
    public sealed class SalesReceiptWithAdditionalInfoDto : DtoBase
    {
        public uint ConcurrencyToken { get; set; }
        public string UserId { get; set; }
        public Instant CreatedAt { get; set; }
        public List<SalesReceiptWithProductDto> Details { get; set; }
    }
}
