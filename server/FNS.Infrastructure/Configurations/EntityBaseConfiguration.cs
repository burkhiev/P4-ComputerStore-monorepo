using FNS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Configurations
{
    internal class EntityBaseConfiguration : IEntityTypeConfiguration<EntityBase>
    {
        private static string CurrentTimestampFunctionName = "CURRENT_TIMESTAMP";

        public void Configure(EntityTypeBuilder<EntityBase> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.AddedAt).HasDefaultValueSql(CurrentTimestampFunctionName);
        }
    }
}
