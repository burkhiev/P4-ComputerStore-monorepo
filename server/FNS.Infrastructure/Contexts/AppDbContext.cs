using FNS.Domain.Models.Identity;
using FNS.Domain.Models.Products;
using FNS.Domain.Models.SalesReceipts;
using FNS.Domain.Models.ShoppingCarts;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FNS.Contexts.Infrastructure
{
    public sealed class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
            // do nothing
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<SalesReceipt> SalesReceipts { get; set; }
        public DbSet<SalesReceiptWithProduct> SalesReceiptsWithProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if(optionsBuilder.IsConfigured)
            {
                return;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
