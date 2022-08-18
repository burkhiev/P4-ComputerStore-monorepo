using FNS.Domain.Models.Measures;
using FNS.Domain.Models.Products;
using NodaTime;

namespace FNS.Infrastructure.Initializers.Products
{
    internal class ProductAttributeInitializer : IDataInitializer<ProductAttribute>
    {
        private readonly object _locker = new object();
        private readonly IEnumerable<ProductAttribute> _entities;

        public ProductAttributeInitializer()
        {
            string guidBasis = "00000000-0000-0000-0000-000000";

            lock(_locker)
            {
                var entities = new List<ProductAttribute>
                {
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "01"),
                        Name = AttributeNames.Model,
                        ClrType = typeof(string).Name
                    },
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "02"),
                        Name = AttributeNames.Socket,
                        ClrType = typeof(string).Name
                    },
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "03"),
                        Name = AttributeNames.ManufacturerCode,
                        ClrType = typeof(string).Name
                    },
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "04"),
                        Name = AttributeNames.ReleaseYear,
                        ClrType = typeof(LocalDate).Name
                    },
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "05"),
                        Name = AttributeNames.MaximumThreads,
                        ClrType = typeof(string).Name
                    },
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "06"),
                        Name = AttributeNames.NumberOfPerformanceCores,
                        ClrType = typeof(int).Name
                    },
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "07"),
                        Name = AttributeNames.NumberOfEnergyEfficientCores,
                        ClrType = typeof(int).Name
                    },
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "08"),
                        Name = AttributeNames.L2CacheSize,
                        Measure = Enum.GetName(MemoryUnits.MB),
                        ClrType = typeof(int).Name
                    },
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "09"),
                        Name = AttributeNames.L3CacheSize,
                        Measure = Enum.GetName(MemoryUnits.MB),
                        ClrType = typeof(int).Name
                    },
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "10"),
                        Name = AttributeNames.ProcessTechnology,
                        ClrType = typeof(string).Name
                    },
                    new ProductAttribute
                    {
                        Id = Guid.Parse(guidBasis + "11"),
                        Name = AttributeNames.Core,
                        ClrType = typeof(string).Name
                    },
                };

                _entities = entities.AsReadOnly();
            }
        }

        public IEnumerable<ProductAttribute> Entities => _entities;

        public static class AttributeNames
        {
            public const string Model = "Model";
            public const string Socket = "Socket";
            public const string ManufacturerCode = "Manufacturer code";
            public const string ReleaseYear = "Release year";
            public const string MaximumThreads = "Maximum threads";
            public const string NumberOfPerformanceCores = "Number of performance cores";
            public const string NumberOfEnergyEfficientCores = "Number of energy efficient cores";
            public const string L2CacheSize = "L2 cache size";
            public const string L3CacheSize = "L3 cache size";
            public const string ProcessTechnology = "Process technology";
            public const string Core = "Core";
        }
    }
}
