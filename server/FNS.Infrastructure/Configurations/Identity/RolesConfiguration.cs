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
            builder.HasMany(x => x.UserRoles)
                .WithOne()
                .HasForeignKey(x => x.RoleId)
                .IsRequired();

            builder.HasData(new RolesInitializer().Entities);
        }
    }
}
