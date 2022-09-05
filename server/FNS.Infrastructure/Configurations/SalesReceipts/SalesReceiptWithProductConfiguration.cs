using FNS.Domain.Models.SalesReceipts;
using FNS.Infrastructure.Initializers.SalesReceipts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Configurations.SalesReceipts
{
    internal sealed class SalesReceiptWithProductConfiguration : IEntityTypeConfiguration<SalesReceiptWithProduct>
    {
        public void Configure(EntityTypeBuilder<SalesReceiptWithProduct> builder)
        {
            EntityBaseConfigurator.ConfigureDefault(builder);

            builder.Property(p => p.Amount).IsRequired();

            builder.HasOne(p => p.Product)
                .WithMany(p => p.SalesReceiptsWithProducts)
                .HasForeignKey(p => p.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.SalesReceipt)
                .WithMany(p => p.SalesReceiptsWithProducts)
                .HasForeignKey(p => p.SalesReceiptId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new SalesReceiptWithProductInitializer().Entities);
        }
    }
}
