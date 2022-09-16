using FNS.Domain.Models.Balances;
using FNS.Infrastructure.Initializers.Balances;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Configurations.Balances
{
    internal sealed class ProductBalanceConfiguration : IEntityTypeConfiguration<ProductBalance>
    {
        public void Configure(EntityTypeBuilder<ProductBalance> builder)
        {
            EntityBaseConfigurator.ConfigureDefault(builder);

            builder.Property(p => p.Amount).IsRequired().HasDefaultValue(0);

            builder.HasOne(p => p.Product)
                .WithMany(p => p.ProductBalances)
                .HasForeignKey(p => p.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new ProductBalanceInitializer().Entities);
        }
    }
}
