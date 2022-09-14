using FNS.Domain.Models.Identity;
using FNS.Infrastructure.Initializers.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Configurations.Identity
{
    internal sealed class RolesConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasIndex(x => x.Name)
                .IsUnique();

            builder.UseXminAsConcurrencyToken();

            builder.Property(p => p.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd();

            builder.Property(p => p.UpdatedAt)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAddOrUpdate();

            builder.HasMany(x => x.UserRoles)
                .WithOne()
                .HasForeignKey(x => x.RoleId)
                .IsRequired();

            builder.HasData(new RolesInitializer().Entities);
        }
    }
}
