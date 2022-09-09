using FNS.Domain.Models.Balances;
using FNS.Domain.Models.Purchases;
using FNS.Domain.Models.SalesReceipts;
using FNS.Domain.Models.ShoppingCarts;

namespace FNS.Domain.Models.Products
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string ProductCode { get; set; }
        public decimal Price { get; set; }
        public string SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual List<ProductAttributeValue>? ProductAttributeValues { get; set; }
        public virtual List<ShoppingCartItem>? ShoppingCartItems { get; set; }
        public virtual List<SalesReceiptWithProduct>? SalesReceiptsWithProducts { get; set; }
        public virtual List<ProductBalance>? ProductBalances { get; set; }
        public virtual List<PurchaseInvoiceItem>? PurchaseInvoiceItems { get; set; }
    }
}
