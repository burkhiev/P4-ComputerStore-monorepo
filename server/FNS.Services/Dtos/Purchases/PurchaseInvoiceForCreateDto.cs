namespace FNS.Services.Dtos.Purchases
{
    public sealed class PurchaseInvoiceForCreateDto
    {
        public string UserId { get; set; }
        public List<PurchaseInvoiceItemForCreateDto> Items { get; set; }
    }
}
