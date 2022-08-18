using FNS.Domain.Models.Products;
using FNS.Infrastructure.Initializers.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //var initializer = new CategoryInitializer();
            //builder.HasData(initializer.Entities);
        }
    }
}
