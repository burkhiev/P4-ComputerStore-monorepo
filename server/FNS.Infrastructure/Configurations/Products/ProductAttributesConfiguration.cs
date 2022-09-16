using FNS.Domain.Models.Products;
using FNS.ContextsInfrastructure.Initializers.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FNS.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace FNS.ContextsInfrastructure.Configurations.Products
{
    internal sealed class ProductAttributesConfiguration : IEntityTypeConfiguration<ProductAttribute>
    {
        public const int MaxNameLength = 100;

        public void Configure(EntityTypeBuilder<ProductAttribute> builder)
        {
            EntityBaseConfigurator.ConfigureDefault(builder);

            builder.HasIndex(p => p.Name)
                .IsUnique();

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            builder.Property(p => p.ClrType)
                .IsRequired();

            builder.HasOne(p => p.Group)
                .WithMany(p => p.ProductAttributes)
                .HasForeignKey(p => p.GroupId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new ProductAttributesInitializer().Entities);
        }
    }
}
