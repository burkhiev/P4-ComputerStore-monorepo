using FNS.ContextsInfrastructure.Initializers;
using FNS.Domain.Models.Identity;

namespace FNS.Infrastructure.Initializers.Identity
{
    internal sealed class UsersInitializer : IDataInitializer<User>
    {
        private readonly IEnumerable<User> _entities;

        public UsersInitializer()
        {
            string guidBasis = "00000000-0000-0000-0000-00000000000";

            var users = new List<User>
            {
                new User
                {
                    Id = Guid.Parse(guidBasis + "1").ToString(),
                    Email = "user1@gmail.ru",
                    UserName = "user1",
                },
                new User
                {
                    Id = Guid.Parse(guidBasis + "2").ToString(),
                    Email = "user2@gmail.ru",
                    UserName = "user2",
                },
                new User
                {
                    Id = Guid.Parse(guidBasis + "3").ToString(),
                    Email = "admin@yandex.ru",
                    UserName = "admin",
                },
            };

            _entities = users.AsReadOnly();
        }

        public IEnumerable<User> Entities => _entities;
    }
}
