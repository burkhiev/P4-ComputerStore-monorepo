using FNS.Domain.Models.ShoppingCarts;
using FNS.Infrastructure.Initializers.ShoppingCarts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Configurations.ShoppingCarts
{
    internal sealed class ShoppingCartsConfiguration : IEntityTypeConfiguration<ShoppingCart>
    {
        public void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            EntityBaseConfigurator.ConfigureDefault(builder);

            builder.HasOne(p => p.User)
                .WithOne(p => p.ShoppingCart)
                .HasForeignKey<ShoppingCart>(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new ShoppingCartsInitializer().Entities);
        }
    }
}
