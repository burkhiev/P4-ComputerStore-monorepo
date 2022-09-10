using NodaTime;

namespace FNS.Domain.Models.Products
{
    public class SubCategory : EntityBase
    {
        public string Name { get; set; }
        public Instant CreatedAt { get; set; }
        public virtual List<Product>? Products { get; set; }
    }
}
