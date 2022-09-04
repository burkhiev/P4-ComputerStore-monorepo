namespace FNS.Domain.Models.Products
{
    public class BalanceTable : EntityBase, IEntityBase
    {
        public string ProductId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; } = 0;
    }
}
