using FNS.Domain.Models.Products;
using FNS.Infrastructure.Abstractions;
using FNS.Infrastructure.Initializers.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Configurations.Products
{
    internal sealed class ProductsConfiguration : IAppEntityTypeConfiguration<Product>
    {
        public const int MaxNameLength = 200;
        public const int MaxDescriptionLength = 1000;
        public const int MaxProductCodeLength = 32;

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            SharedConfigureActions(builder);

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
                .OnDelete(DeleteBehavior.SetNull);

            var init = new ProductsInitializer();
            builder.HasData(init.Entities);
        }

        public void SharedConfigureActions(EntityTypeBuilder<Product> builder)
        {
            builder.UseXminAsConcurrencyToken();

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Tumbstone)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(p => p.CreatedAt)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(p => p.UpdatedAt)
                .IsRequired()
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}
