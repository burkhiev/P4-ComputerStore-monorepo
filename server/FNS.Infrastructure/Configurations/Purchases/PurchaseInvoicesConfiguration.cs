using FNS.Domain.Models.Purchases;
using FNS.Infrastructure.Initializers.Purchases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Configurations.Purchases
{
    internal sealed class PurchaseInvoicesConfiguration : IEntityTypeConfiguration<PurchaseInvoice>
    {
        public void Configure(EntityTypeBuilder<PurchaseInvoice> builder)
        {
            EntityBaseConfigurator.ConfigureDefault(builder);

            builder.Property(x => x.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(x => x.CreatedAt)
                .Metadata
                .SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);

            builder.HasOne(x => x.User)
                .WithMany(u => u.PurchaseInvoices)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new PurchaseInvoiceInitializer().Entities);
        }
    }
}
