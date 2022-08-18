using Bogus;
using FNS.Domain.Models.Products;
using FNS.Infrastructure.Configurations.Products;
using NodaTime;

namespace FNS.Infrastructure.Initializers.Products
{
    internal class ProductInitializer : IDataInitializer<Product>
    {
        private static readonly object _locker = new object();
        private static readonly IEnumerable<Product> _entities;

        static ProductInitializer()
        {
            var faker = new Faker();

            lock(_locker)
            {
                var entities = new List<Product>
                {
                    new Product
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        Name = "AMD Ryzen 5 3600 OEM",
                        AddedAt = Instant.FromDateTimeUtc(DateTime.UtcNow),
                        Description = GetDescription(),
                        Price = 12_599,
                        ProductCode = "1372637"
                    },
                    new Product
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                        Name = "AMD Ryzen 5 3600 BOX",
                        AddedAt = Instant.FromDateTimeUtc(DateTime.UtcNow),
                        Description = GetDescription(),
                        Price = 12_899,
                        ProductCode = "5059834"
                    },
                    new Product
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                        Name = "AMD Ryzen 5 PRO 4650G OEM",
                        AddedAt = Instant.FromDateTimeUtc(DateTime.UtcNow),
                        Description = GetDescription(),
                        Price = 12_599,
                        ProductCode = "1689358"
                    },
                    new Product
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                        Name = "AMD Ryzen 5 5600G OEM",
                        AddedAt = Instant.FromDateTimeUtc(DateTime.UtcNow),
                        Description = GetDescription(),
                        Price = 14_899,
                        ProductCode = "4819672"
                    },
                    new Product
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                        Name = "AMD Ryzen 5 5600X OEM",
                        AddedAt = Instant.FromDateTimeUtc(DateTime.UtcNow),
                        Description = GetDescription(),
                        Price = 16_199,
                        ProductCode = "4721161"
                    },
                };

                _entities = entities.AsReadOnly();
            }
        }

        private static string GetDescription()
        {
            var faker = new Faker();
            string? description = null;

            while(description is null || description.Length > ProductsConfiguration.MaxDescriptionLength)
            {
                description = faker.Lorem.Paragraphs(5);
            }

            return description;
        }

        public IEnumerable<Product> Entities => _entities;
    }
}
