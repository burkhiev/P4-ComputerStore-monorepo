using FNS.ContextsInfrastructure.Initializers;
using Microsoft.AspNetCore.Identity;

namespace FNS.Infrastructure.Initializers.Identity
{
    internal sealed class IdentityRolesInitializer : IDataInitializer<IdentityRole>
    {
        private readonly IEnumerable<IdentityRole> _entities;

        public IdentityRolesInitializer()
        {
            var guidBasis1 = "00000000-0000-0000-0000-00000000000";

            var roles = new List<IdentityRole>
            {
                new IdentityRole("admin") { Id = Guid.Parse(guidBasis1 + "1").ToString() },
                new IdentityRole("user") { Id = Guid.Parse(guidBasis1 + "2").ToString() },
            };

            _entities = roles.AsReadOnly();
        }

        public IEnumerable<IdentityRole> Entities => _entities;
    }
}
