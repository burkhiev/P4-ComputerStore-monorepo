using FNS.Domain.Models.Products;
using Microsoft.EntityFrameworkCore;

namespace FNS.Infrastructure
{
    public sealed class AppDbContext : DbContext
    {
        private const string DefaultConnectionString = "server=localhost; port=5432; database=p4_fns_db; user id=fns_admin; password_fns_admin;";

        public AppDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        //public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if(optionsBuilder.IsConfigured)
            {
                return;
            }

            optionsBuilder.UseNpgsql(DefaultConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
