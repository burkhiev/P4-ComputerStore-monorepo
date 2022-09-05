using FNS.Domain.Models.Products;
using FNS.ContextsInfrastructure.Initializers.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FNS.Infrastructure.Configurations;

namespace FNS.ContextsInfrastructure.Configurations.Products
{
    internal sealed class ProductsConfiguration : IEntityTypeConfiguration<Product>
    {
        public const int MaxNameLength = 200;
        public const int MaxDescriptionLength = 1000;
        public const int MaxProductCodeLength = 32;

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            EntityBaseConfigurator.ConfigureDefault(builder);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            builder.Property(p => p.Description)
                .HasMaxLength(MaxDescriptionLength);

            builder.Property(p => p.ProductCode)
                .HasMaxLength(MaxProductCodeLength);

            builder.Property(p => p.Price)
                .HasDefaultValue(0);

            builder.HasOne(p => p.SubCategory)
                .WithMany(sc => sc.Products)
                .HasForeignKey(p => p.SubCategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            var init = new ProductsInitializer();
            builder.HasData(init.Entities);
        }
    }
}
