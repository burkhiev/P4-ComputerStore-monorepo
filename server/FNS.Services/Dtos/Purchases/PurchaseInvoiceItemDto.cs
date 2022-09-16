namespace FNS.Services.Dtos.Purchases
{
    public sealed class PurchaseInvoiceItemDto
    {
        public string Id { get; set; }
        public string PurchaseInvoiceId { get; set; }
        public string ProductId { get; set; }
        public int Amount { get; set; }
    }
}
