using FNS.Domain.Models.Products;
using FNS.Infrastructure.Abstractions;
using FNS.Infrastructure.Initializers.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Configurations.Products
{
    internal class ProductAttributeValueConfiguration : IAppEntityTypeConfiguration<ProductAttributeValue>
    {
        public const int MaxValueLength = 300;

        public void Configure(EntityTypeBuilder<ProductAttributeValue> builder)
        {
            builder.Property(p => p.Value).HasMaxLength(MaxValueLength);

            builder.HasOne(p => p.Product)
                .WithMany(p => p.ProductAttributeValues)
                .HasForeignKey(p => p.ProductId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(p => p.ProductAttribute)
                .WithMany(pa => pa.ProductAttributeValues)
                .HasForeignKey(p => p.ProductAttributeId)
                .OnDelete(DeleteBehavior.SetNull);

            var init = new ProductAttributeValuesInitializer();
            builder.HasData(init.Entities);
        }

        public void SharedConfigureActions(EntityTypeBuilder<ProductAttributeValue> builder)
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
