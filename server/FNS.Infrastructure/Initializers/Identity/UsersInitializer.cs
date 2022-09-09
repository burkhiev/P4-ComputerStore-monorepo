using FNS.ContextsInfrastructure.Initializers;
using FNS.Domain.Models.Identity;
using Microsoft.AspNetCore.Identity;
using NodaTime;

namespace FNS.Infrastructure.Initializers.Identity
{
    internal sealed class UsersInitializer : IDataInitializer<User>
    {
        private readonly IEnumerable<User> _entities;

        public UsersInitializer()
        {
            string guidBasis = "00000000-0000-0000-0000-00000000000";
            var hasher = new PasswordHasher<User>();

            var user1Name = "user1";
            var user1Email = "user1@gmail.ru";

            var user2Name = "user2";
            var user2Email = "user2@gmail.ru";

            var adminName = "admin";
            var adminEmail = "admin@yandex.ru";

            var createdAt = Instant.FromUtc(2022, 09, 08, 17, 11);

            var users = new List<User>
            {
                new User
                {
                    Id = Guid.Parse(guidBasis + "1").ToString(),
                    UserName = user1Name,
                    NormalizedUserName = user1Name.ToUpper(),
                    Email = user1Email,
                    NormalizedEmail = user1Email.ToUpper(),
                    CreatedAt = createdAt,
                },
                new User
                {
                    Id = Guid.Parse(guidBasis + "2").ToString(),
                    UserName = user2Name,
                    NormalizedUserName = user2Name.ToUpper(),
                    Email = user2Email,
                    NormalizedEmail = user2Email.ToUpper(),
                    CreatedAt = createdAt,
                },
                new User
                {
                    Id = Guid.Parse(guidBasis + "3").ToString(),
                    UserName = adminName,
                    NormalizedUserName = adminName.ToUpper(),
                    Email = adminEmail,
                    NormalizedEmail = adminEmail.ToUpper(),
                    CreatedAt = createdAt,
                },
            };

            users[0].PasswordHash = hasher.HashPassword(users[0], "user1");
            users[1].PasswordHash = hasher.HashPassword(users[1], "user2");
            users[2].PasswordHash = hasher.HashPassword(users[2], "admin");

            _entities = users.AsReadOnly();
        }

        public IEnumerable<User> Entities => _entities;
    }
}
