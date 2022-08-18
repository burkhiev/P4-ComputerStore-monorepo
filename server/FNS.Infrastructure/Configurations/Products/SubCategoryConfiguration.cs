using FNS.Domain.Models.Products;
using FNS.Infrastructure.Initializers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Configurations.Products
{
    internal sealed class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public const int MaxNameLength = 100;

        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.UseXminAsConcurrencyToken();

            //builder.HasKey(x => x.Id);
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);
            //builder.Property(p => p.AddedAt)
            //    .IsRequired()
            //    .HasDefaultValueSql("CURRENT_TIMESTAMP");

            var init = new InitializedDataRepository();
            builder.HasData(init.SubCategories);
        }
    }
}
