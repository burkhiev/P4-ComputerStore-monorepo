using Bogus;
using FNS.Domain.Models.Products;
using FNS.ContextsInfrastructure.Configurations.Products;

namespace FNS.ContextsInfrastructure.Initializers.Products
{
    internal sealed class ProductsInitializer : IDataInitializer<Product>
    {
        private readonly IEnumerable<Product> _entities;

        public ProductsInitializer()
        {
            if(_entities is not null)
            {
                return;
            }

            var processorsSubCategory = new SubCategoriesInitializer().Entities
                .FirstOrDefault(e => e.Name == "Процессоры");

            if(processorsSubCategory is null)
            {
                throw new InvalidDataException();
            }

            var faker = new Faker();
            string guidBasis = "00000000-0000-0000-0000-00000000000";

            var entities = new List<Product>
                {
                    new Product
                    {
                        Id = Guid.Parse(guidBasis + "1").ToString(),
                        Name = "AMD Ryzen 5 3600 OEM",
                        Description = GetDescription(),
                        Price = 12_599,
                        ProductCode = "1372637",
                        SubCategoryId = processorsSubCategory.Id
                    },
                    new Product
                    {
                        Id = Guid.Parse(guidBasis + "2").ToString(),
                        Name = "AMD Ryzen 5 3600 BOX",
                        Description = GetDescription(),
                        Price = 12_899,
                        ProductCode = "5059834",
                        SubCategoryId = processorsSubCategory.Id
                    },
                    new Product
                    {
                        Id = Guid.Parse(guidBasis + "3").ToString(),
                        Name = "AMD Ryzen 5 PRO 4650G OEM",
                        Description = GetDescription(),
                        Price = 12_599,
                        ProductCode = "1689358",
                        SubCategoryId = processorsSubCategory.Id
                    },
                    new Product
                    {
                        Id = Guid.Parse(guidBasis + "4").ToString(),
                        Name = "AMD Ryzen 5 5600X OEM",
                        Description = GetDescription(),
                        Price = 16_199,
                        ProductCode = "4721161",
                        SubCategoryId = processorsSubCategory.Id
                    },
                };

            _entities = entities.AsReadOnly();
        }

        private string GetDescription()
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
