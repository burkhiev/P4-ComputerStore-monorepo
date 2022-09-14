using FNS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Configurations
{
    internal static class EntityBaseConfigurator
    {
        public static void ConfigureDefault<T>(EntityTypeBuilder<T> builder)
            where T : class, IEntityBase, new()
        {
            builder.HasKey(p => p.Id);

            builder.UseXminAsConcurrencyToken();

            builder.Property(p => p.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd();

            builder.Property(p => p.CreatedAt)
                .Metadata
                .SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);

            builder.Property(p => p.UpdatedAt)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(p => p.UpdatedAt)
                .Metadata
                .SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);
        }
    }
}
