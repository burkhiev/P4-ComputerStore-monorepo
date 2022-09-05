using FNS.Domain.Models.Purchases;
using FNS.Infrastructure.Initializers.Purchases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Configurations.Purchases
{
    internal sealed class PurchaseInvoiceItemsConfiguration : IEntityTypeConfiguration<PurchaseInvoiceItem>
    {
        public void Configure(EntityTypeBuilder<PurchaseInvoiceItem> builder)
        {
            EntityBaseConfigurator.ConfigureDefault(builder);

            builder.Property(p => p.Amount).IsRequired().HasDefaultValue(0);

            builder.HasOne(p => p.PurchaseInvoice)
                .WithMany(p => p.PurchaseInvoiceItems)
                .HasForeignKey(p => p.PurchaseInvoiceId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Product)
                .WithMany(p => p.PurchaseInvoiceItems)
                .HasForeignKey(p => p.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new PurchaseInvoiceItemsInitializer().Entities);
        }
    }
}
