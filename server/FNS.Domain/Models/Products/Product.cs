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
        //public Category Category { get; set; }
        //public Guid CategoryId { get; set; }
        public string SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public List<ProductAttributeValue> ProductAttributeValues { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public List<SalesReceiptWithProduct> SalesReceiptsWithProducts { get; set; }
    }
}
