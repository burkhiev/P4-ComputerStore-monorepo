using Bogus;
using FNS.Domain.Models.Products;
using FNS.Infrastructure.Configurations.Products;
using NodaTime;

namespace FNS.Infrastructure.Initializers.Products
{
    internal class ProductsInitializer : IDataInitializer<Product>
    {
        private static readonly object _locker = new object();
        private static readonly IEnumerable<Product> _entities;

        static ProductsInitializer()
        {
            var faker = new Faker();

            lock(_locker)
            {
                if(_entities is not null)
                {
                    return;
                }

                string guidBasis = "00000000-0000-0000-0000-00000000000";
                var subCategoryInit = new SubCategoriesInitializer();
                var processorsSubCategory = subCategoryInit.Entities.FirstOrDefault(e => e.Name == "Процессоры");

                if(processorsSubCategory is null)
                {
                    throw new InvalidDataException();
                }

                var entities = new List<Product>
                {
                    new Product
                    {
                        Id = Guid.Parse(guidBasis + "1"),
                        Name = "AMD Ryzen 5 3600 OEM",
                        CreatedAt = Instant.FromDateTimeUtc(DateTime.UtcNow),
                        Description = GetDescription(),
                        Price = 12_599,
                        ProductCode = "1372637",
                        SubCategoryId = processorsSubCategory.Id
                    },
                    new Product
                    {
                        Id = Guid.Parse(guidBasis + "2"),
                        Name = "AMD Ryzen 5 3600 BOX",
                        CreatedAt = Instant.FromDateTimeUtc(DateTime.UtcNow),
                        Description = GetDescription(),
                        Price = 12_899,
                        ProductCode = "5059834",
                        SubCategoryId = processorsSubCategory.Id
                    },
                    new Product
                    {
                        Id = Guid.Parse(guidBasis + "3"),
                        Name = "AMD Ryzen 5 PRO 4650G OEM",
                        CreatedAt = Instant.FromDateTimeUtc(DateTime.UtcNow),
                        Description = GetDescription(),
                        Price = 12_599,
                        ProductCode = "1689358",
                        SubCategoryId = processorsSubCategory.Id
                    },
                    new Product
                    {
                        Id = Guid.Parse(guidBasis + "4"),
                        Name = "AMD Ryzen 5 5600X OEM",
                        CreatedAt = Instant.FromDateTimeUtc(DateTime.UtcNow),
                        Description = GetDescription(),
                        Price = 16_199,
                        ProductCode = "4721161",
                        SubCategoryId = processorsSubCategory.Id
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
