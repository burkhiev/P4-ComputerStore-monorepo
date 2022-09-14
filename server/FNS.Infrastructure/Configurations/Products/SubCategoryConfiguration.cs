using FNS.Domain.Models.Products;
using FNS.ContextsInfrastructure.Initializers.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FNS.Infrastructure.Configurations;

namespace FNS.ContextsInfrastructure.Configurations.Products
{
    internal sealed class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public const int MaxNameLength = 100;

        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            EntityBaseConfigurator.ConfigureDefault(builder);

            builder.HasIndex(x => x.Name)
                .IsUnique();

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            builder.HasData(new SubCategoriesInitializer().Entities);
        }
    }
}
