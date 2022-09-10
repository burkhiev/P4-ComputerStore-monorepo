using FNS.Domain.Models.Products;
using FNS.ContextsInfrastructure.Initializers.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FNS.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FNS.ContextsInfrastructure.Configurations.Products
{
    internal sealed class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public const int MaxNameLength = 100;

        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            EntityBaseConfigurator.ConfigureDefault(builder);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            builder.Property(p => p.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(p => p.CreatedAt)
                .Metadata
                .SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);

            builder.HasData(new SubCategoriesInitializer().Entities);
        }
    }
}
