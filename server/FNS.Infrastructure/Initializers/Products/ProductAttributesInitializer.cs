using FNS.Domain.Models.Products;
using FNS.Infrastructure.Initializers.Products;

namespace FNS.ContextsInfrastructure.Initializers.Products
{
    internal sealed class ProductAttributesInitializer : IDataInitializer<ProductAttribute>
    {
        private readonly IEnumerable<ProductAttribute> _entities;

        public ProductAttributesInitializer()
        {
            var groups = new ProductAttributeGroupsInitializer().Entities.ToArray();

            var commonGroup = groups[0];
            var procGroup = groups[1];

            string guidBasis = "00000000-0000-0000-0000-00000000000";

            var entities = new List<ProductAttribute>
                {
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "1").ToString(),
                        Name = AttributeNames.Model,
                        ClrType = typeof(string).Name,
                        GroupId = commonGroup.Id,
                    },
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "2").ToString(),
                        Name = AttributeNames.Socket,
                        ClrType = typeof(string).Name,
                        GroupId = procGroup.Id,
                    },
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "3").ToString(),
                        Name = AttributeNames.ReleaseYear,
                        ClrType = typeof(int).Name,
                        GroupId = commonGroup.Id,
                    },
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "4").ToString(),
                        Name = AttributeNames.TotalNumberOfCores,
                        ClrType = typeof(int).Name,
                        GroupId = procGroup.Id,
                    },
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "5").ToString(),
                        Name = AttributeNames.MaximumThreads,
                        ClrType = typeof(string).Name,
                        GroupId = procGroup.Id,
                    }
                };

            _entities = entities.AsReadOnly();
        }

        public IEnumerable<ProductAttribute> Entities => _entities;

        public static class AttributeNames
        {
            public const string Model = "Model";
            public const string Socket = "Socket";
            public const string ReleaseYear = "Release year";
            public const string TotalNumberOfCores = "Total number of cores";
            public const string MaximumThreads = "Maximum threads";
        }
    }
}
