using FNS.Domain.Models.ShoppingCarts;
using FNS.Infrastructure.Initializers.ShoppingCarts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Configurations.ShoppingCarts
{
    internal sealed class ShoppingCartItemsConfiguration : IEntityTypeConfiguration<ShoppingCartItem>
    {
        public void Configure(EntityTypeBuilder<ShoppingCartItem> builder)
        {
            EntityBaseConfigurator.ConfigureDefault(builder);

            builder.Property(p => p.Amount).IsRequired();

            builder.HasOne(p => p.ShoppingCart)
                .WithMany(p => p.ShoppingCartItems)
                .HasForeignKey(p => p.ShoppingCartId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Product)
                .WithMany(p => p.ShoppingCartItems)
                .HasForeignKey(p => p.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            var init = new ShoppingCartsItemsInitializer();
            builder.HasData(init.Entities);
        }
    }
}
