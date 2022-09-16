using FNS.Domain.Models.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FNS.Infrastructure.Initializers.Products;

namespace FNS.Infrastructure.Configurations.Products
{
    internal sealed class ProductAttributeGroupConfiguration : IEntityTypeConfiguration<ProductAttributeGroup>
    {
        public const int MaxNameLength = 100;

        public void Configure(EntityTypeBuilder<ProductAttributeGroup> builder)
        {
            EntityBaseConfigurator.ConfigureDefault(builder);

            builder.HasIndex(p => p.Name)
                .IsUnique();

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            builder.HasData(new ProductAttributeGroupsInitializer().Entities);
        }
    }
}
