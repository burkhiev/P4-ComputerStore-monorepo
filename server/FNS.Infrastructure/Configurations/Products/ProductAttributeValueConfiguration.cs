using FNS.Domain.Models.Products;
using FNS.Infrastructure.Initializers.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Configurations.Products
{
    internal class ProductAttributeValueConfiguration : IEntityTypeConfiguration<ProductAttributeValue>
    {
        public const int MaxValueLength = 300;

        public void Configure(EntityTypeBuilder<ProductAttributeValue> builder)
        {
            builder.UseXminAsConcurrencyToken();

            //builder.Property(x => x.Id).IsRequired();
            builder.Property(p => p.ProductId).IsRequired();
            builder.Property(p => p.ProductAttributeId).IsRequired();
            builder.Property(p => p.Value).HasMaxLength(MaxValueLength);
            //builder.Property(p => p.AddedAt).IsRequired().HasDefaultValueSql("CURRENT_TIMESTAMP");

            var init = new ProductAttributeValuesInitializer();
            builder.HasData(init.Entities);
        }
    }
}
