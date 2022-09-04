using FNS.Domain.Models.SalesReceipts;
using FNS.Infrastructure.Initializers.SalesReceipts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Configurations.SalesReceipts
{

    internal sealed class SalesReceiptConfiguration : IEntityTypeConfiguration<SalesReceipt>
    {
        public void Configure(EntityTypeBuilder<SalesReceipt> builder)
        {
            EntityBaseConfigurator.ConfigureDefault(builder);

            builder.Property(p => p.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd();

            builder.Property(p => p.CreatedAt).Metadata
                .SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);

            builder.Property(p => p.CreatedAt).Metadata
                .SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

            builder.HasOne(p => p.User)
                .WithOne(p => p.SalesReceipt)
                .HasForeignKey<SalesReceipt>(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            var init = new SalesReceiptInitializer();
            builder.HasData(init.Entities);
        }
    }
}
