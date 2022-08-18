using FNS.Domain.Models.Products;

namespace FNS.Infrastructure.Initializers.Products
{
    internal class CategoryInitializer : IDataInitializer<Category>
    {
        private static readonly object _locker = new object();
        private static readonly IEnumerable<Category> _entities;

        static CategoryInitializer()
        {
            lock(_locker)
            {
                _entities = new List<Category>
                {
                    new Category { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Комплектующие для ПК" },
                    new Category { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Компьютеры, ноутбуки и ПО" },
                    new Category { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Периферия и аксессуары" },
                };
            }
        }

        public IEnumerable<Category> Entities => _entities;
    }
}
