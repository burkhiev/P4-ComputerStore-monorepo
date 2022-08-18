using FNS.Domain.Models.Products;
using FNS.Infrastructure.Initializers.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Configurations
{
    internal sealed class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            var init = new SubCategoryInitializer();
            builder.HasData(init.Entities);
        }
    }
}
