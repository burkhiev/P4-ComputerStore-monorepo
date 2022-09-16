using FNS.Domain.Models.Products;

namespace FNS.Domain.Models.Balances
{
    public class ProductBalance : EntityBase
    {
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Amount { get; set; } = 0;
    }
}
