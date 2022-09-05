using FNS.Domain.Models.Balances;
using FNS.Domain.Models.Purchases;
using FNS.Domain.Models.SalesReceipts;
using FNS.Domain.Models.ShoppingCarts;

namespace FNS.Domain.Models.Products
{
    public sealed class Product : EntityBase
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string ProductCode { get; set; }
        public decimal Price { get; set; }
        public string SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public List<ProductAttributeValue>? ProductAttributeValues { get; set; }
        public List<ShoppingCartItem>? ShoppingCartItems { get; set; }
        public List<SalesReceiptWithProduct>? SalesReceiptsWithProducts { get; set; }
        public List<ProductBalance>? ProductBalances { get; set; }
        public List<PurchaseInvoiceItem>? PurchaseInvoiceItems { get; set; }
    }
}
