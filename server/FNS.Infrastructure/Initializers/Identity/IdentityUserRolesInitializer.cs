using FNS.ContextsInfrastructure.Initializers;
using Microsoft.AspNetCore.Identity;

namespace FNS.Infrastructure.Initializers.Identity
{
    public sealed class IdentityUserRolesInitializer : IDataInitializer<IdentityUserRole<string>>
    {
        private readonly IEnumerable<IdentityUserRole<string>> _entities;

        public IdentityUserRolesInitializer()
        {   
            var roles = new RolesInitializer().Entities.ToList();
            var users = new UsersInitializer().Entities.ToList();

            var adminRole = roles[0];
            var userRole = roles[1];

            var user1 = users[0];
            var user2 = users[1];
            var admin = users[2];

            var entities = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                { 
                    UserId = admin.Id,
                    RoleId = adminRole.Id
                },
                new IdentityUserRole<string>
                { 
                    UserId = user1.Id,
                    RoleId = userRole.Id
                },
                new IdentityUserRole<string>
                { 
                    UserId = user2.Id,
                    RoleId = userRole.Id
                },
            };

            _entities = entities.AsReadOnly();
        }

        public IEnumerable<IdentityUserRole<string>> Entities => _entities;
    }
}
