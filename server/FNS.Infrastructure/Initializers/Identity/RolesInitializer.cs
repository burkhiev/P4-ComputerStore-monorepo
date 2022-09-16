using FNS.ContextsInfrastructure.Initializers;
using FNS.Domain.Models.Identity;

namespace FNS.Infrastructure.Initializers.Identity
{
    internal sealed class RolesInitializer : IDataInitializer<Role>
    {
        private readonly IEnumerable<Role> _entities;

        public RolesInitializer()
        {
            string adminRoleName = "admin";
            string userRoleName = "user";

            var guidBasis1 = "00000000-0000-0000-0000-00000000000";

            var roles = new List<Role>
            {
                new Role() 
                { 
                    Id = Guid.Parse(guidBasis1 + "1").ToString(),
                    Name = adminRoleName,
                    NormalizedName = adminRoleName.ToUpper(),
                },
                new Role() 
                { 
                    Id = Guid.Parse(guidBasis1 + "2").ToString(),
                    Name = userRoleName,
                    NormalizedName = userRoleName.ToUpper(),
                },
            };

            _entities = roles.AsReadOnly();
        }

        public IEnumerable<Role> Entities => _entities;
    }
}
