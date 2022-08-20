using FNS.Domain.Models.Products;
using FNS.Infrastructure.Abstractions;
using FNS.Infrastructure.Initializers.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Configurations.Products
{
    internal sealed class SubCategoryConfiguration : IAppEntityTypeConfiguration<SubCategory>
    {
        public const int MaxNameLength = 100;

        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            SharedConfigureActions(builder);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            var init = new SubCategoriesInitializer();
            builder.HasData(init.Entities);
        }

        public void SharedConfigureActions(EntityTypeBuilder<SubCategory> builder)
        {
            builder.UseXminAsConcurrencyToken();

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Tumbstone)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(p => p.CreatedAt)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(p => p.UpdatedAt)
                .IsRequired()
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}
