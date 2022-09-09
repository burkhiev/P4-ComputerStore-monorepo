namespace FNS.Services.Dtos.Purchases
{
    public sealed class PurchaseInvoiceItemWithAdditionalInfoDto
    {
        public string Id { get; set; }
        public string PurchaseInvoiceId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public int Amount { get; set; }
    }
}
