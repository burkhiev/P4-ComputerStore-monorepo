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
        }
    }
}
