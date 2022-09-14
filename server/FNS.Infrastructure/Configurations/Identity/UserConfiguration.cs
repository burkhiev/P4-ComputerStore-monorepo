using FNS.Domain.Models.Identity;
using FNS.Infrastructure.Initializers.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FNS.Infrastructure.Configurations.Identity
{
    internal sealed class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            EntityBaseConfigurator.ConfigureDefault(builder);

            builder.HasMany(x => x.UserRoles)
                .WithOne()
                .HasForeignKey(x => x.UserId)
                .IsRequired();

            builder.HasData(new UsersInitializer().Entities);
        }
    }
}
