using FNS.Domain.Models.Products;
using FNS.ContextsInfrastructure.Initializers.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FNS.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FNS.ContextsInfrastructure.Configurations.Products
{
    internal sealed class ProductAttributesConfiguration : IEntityTypeConfiguration<ProductAttribute>
    {
        public const int MaxNameLength = 100;
        public const int MaxMeasureLength = 50;

        public void Configure(EntityTypeBuilder<ProductAttribute> builder)
        {
            EntityBaseConfigurator.ConfigureDefault(builder);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            builder.Property(p => p.Measure)
                .HasMaxLength(MaxMeasureLength);

            builder.Property(p => p.ClrType)
                .IsRequired();

            builder.Property(p => p.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(p => p.CreatedAt)
                .Metadata
                .SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);

            builder.HasData(new ProductAttributesInitializer().Entities);
        }
    }
}
