using FNS.Domain.Models.Products;
using FNS.ContextsInfrastructure.Initializers.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FNS.Infrastructure.Configurations;

namespace FNS.ContextsInfrastructure.Configurations.Products
{
    internal sealed class ProductAttributeValueConfiguration : IEntityTypeConfiguration<ProductAttributeValue>
    {
        public const int MaxValueLength = 300;

        public void Configure(EntityTypeBuilder<ProductAttributeValue> builder)
        {
            EntityBaseConfigurator.ConfigureDefault(builder);

            builder.Property(p => p.Value).HasMaxLength(MaxValueLength);

            builder.HasOne(p => p.Product)
                .WithMany(p => p.ProductAttributeValues)
                .HasForeignKey(p => p.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.ProductAttribute)
                .WithMany(pa => pa.ProductAttributeValues)
                .HasForeignKey(p => p.ProductAttributeId)
                .OnDelete(DeleteBehavior.Cascade);

            var init = new ProductAttributeValuesInitializer();
            builder.HasData(init.Entities);
        }
    }
}
