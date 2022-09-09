using FNS.ContextsInfrastructure.Initializers;
using FNS.Domain.Models.Identity;

namespace FNS.Infrastructure.Initializers.Identity
{
    internal sealed class RolesInitializer : IDataInitializer<Role>
    {
        private readonly IEnumerable<Role> _entities;

        public RolesInitializer()
        {
            var guidBasis1 = "00000000-0000-0000-0000-00000000000";

            var roles = new List<Role>
            {
                new Role("admin") { Id = Guid.Parse(guidBasis1 + "1").ToString() },
                new Role("user") { Id = Guid.Parse(guidBasis1 + "2").ToString() },
            };

            _entities = roles.AsReadOnly();
        }

        public IEnumerable<Role> Entities => _entities;
    }
}
