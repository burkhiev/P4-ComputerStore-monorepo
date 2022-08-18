using FNS.Domain.Models.Products;
using FNS.Infrastructure.Initializers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Configurations.Products
{
    internal sealed class ProductsConfiguration : IEntityTypeConfiguration<Product>
    {
        public const int MaxNameLength = 200;
        public const int MaxDescriptionLength = 1000;
        public const int MaxProductCodeLength = 32;

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.UseXminAsConcurrencyToken();

            //builder.HasKey(p => p.Id);
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);
            builder.Property(p => p.Description)
                .HasMaxLength(MaxDescriptionLength);
            builder.Property(p => p.ProductCode)
                .HasMaxLength(MaxProductCodeLength);
            builder.Property(p => p.Price)
                .HasDefaultValue(0);
            //builder.Property(p => p.AddedAt)
            //    .IsRequired()
            //    .HasDefaultValueSql("CURRENT_TIMESTAMP");

            var init = new InitializedDataRepository();
            builder.HasData(init.Products);
        }
    }
}
