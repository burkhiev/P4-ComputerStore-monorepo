using FNS.Domain.Models.Products;

namespace FNS.Infrastructure.Initializers.Products
{
    internal class SubCategoriesInitializer : IDataInitializer<SubCategory>
    {
        private static readonly object _locker = new object();
        private static readonly IEnumerable<SubCategory> _entities;

        static SubCategoriesInitializer()
        {
            lock(_locker)
            {
                if(_entities is not null)
                {
                    return;
                }

                string guidBasis = "00000000-0000-0000-0000-00000000000";

                var entities = new List<SubCategory>
                {
                    new SubCategory { Id = Guid.Parse(guidBasis + "1"), Name = "Процессоры" },
                    new SubCategory { Id = Guid.Parse(guidBasis + "2"), Name = "Материские платы" },
                    new SubCategory { Id = Guid.Parse(guidBasis + "3"), Name = "Видеокарты" },
                };

                _entities = entities.AsReadOnly();
            }
        }

        public IEnumerable<SubCategory> Entities => _entities;
    }
}
