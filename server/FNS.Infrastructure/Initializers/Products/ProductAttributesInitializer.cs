using FNS.Domain.Models.Products;

namespace FNS.Infrastructure.Initializers.Products
{
    internal class ProductAttributesInitializer : IDataInitializer<ProductAttribute>
    {
        private readonly object _locker = new object();
        private readonly IEnumerable<ProductAttribute> _entities;

        public ProductAttributesInitializer()
        {
            lock(_locker)
            {
                if(_entities is not null)
                {
                    return;
                }

                string guidBasis = "00000000-0000-0000-0000-00000000000";

                var entities = new List<ProductAttribute>
                {
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "1"),
                        Name = AttributeNames.Model,
                        ClrType = typeof(string).Name
                    },
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "2"),
                        Name = AttributeNames.Socket,
                        ClrType = typeof(string).Name
                    },
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "3"),
                        Name = AttributeNames.ReleaseYear,
                        ClrType = typeof(int).Name
                    },
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "4"),
                        Name = AttributeNames.TotalNumberOfCores,
                        ClrType = typeof(int).Name
                    },
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "5"),
                        Name = AttributeNames.MaximumThreads,
                        ClrType = typeof(string).Name
                    }
                };

                _entities = entities.AsReadOnly();
            }
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
