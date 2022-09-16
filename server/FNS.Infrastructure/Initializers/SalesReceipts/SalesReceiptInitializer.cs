using Bogus;
using FNS.ContextsInfrastructure.Initializers;
using FNS.Domain.Models.SalesReceipts;
using FNS.Infrastructure.Initializers.Identity;
using NodaTime;

namespace FNS.Infrastructure.Initializers.SalesReceipts
{
    internal sealed class SalesReceiptInitializer : IDataInitializer<SalesReceipt>
    {
        private readonly IEnumerable<SalesReceipt> _entities;

        public SalesReceiptInitializer()
        {
            var faker = new Faker();
            var users = new UsersInitializer().Entities.ToArray();

            string guidBasis1 = "00000000-0000-0000-0000-00000000000";

            var receipts = new List<SalesReceipt>
            {
                new SalesReceipt
                {
                    Id = Guid.Parse(guidBasis1 + "1").ToString(),
                    CreatedAt = Instant.FromDateTimeUtc(DateTime.SpecifyKind(faker.Date.Past(), DateTimeKind.Utc)),
                    UserId = users[0].Id,
                },
                new SalesReceipt
                {
                    Id = Guid.Parse(guidBasis1 + "2").ToString(),
                    CreatedAt = Instant.FromDateTimeUtc(DateTime.SpecifyKind(faker.Date.Past(), DateTimeKind.Utc)),
                    UserId = users[1].Id,
                },
                new SalesReceipt
                {
                    Id = Guid.Parse(guidBasis1 + "3").ToString(),
                    CreatedAt = Instant.FromDateTimeUtc(DateTime.SpecifyKind(faker.Date.Past(), DateTimeKind.Utc)),
                    UserId = users[2].Id,
                },
            };

            _entities = receipts.AsReadOnly();
        }

        public IEnumerable<SalesReceipt> Entities => _entities;
    }
}
