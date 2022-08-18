using FNS.Domain.Models.Products;

namespace FNS.Infrastructure.Initializers.Products
{
    internal class SubCategoryInitializer : IDataInitializer<SubCategory>
    {
        private static readonly object _locker = new object();
        private static readonly IEnumerable<SubCategory> _entities;

        static SubCategoryInitializer()
        {
            lock(_locker)
            {
                var entities = new List<SubCategory>
                {
                    new SubCategory { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Процессоры" },
                    new SubCategory { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Материские платы" },
                    new SubCategory { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Видеокарты" },
                };

                _entities = entities.AsReadOnly();
            }
        }

        public IEnumerable<SubCategory> Entities => _entities;
    }
}
