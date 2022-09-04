using FNS.Domain.Models.Products;

namespace FNS.ContextsInfrastructure.Initializers.Products
{
    internal sealed class SubCategoriesInitializer : IDataInitializer<SubCategory>
    {
        private readonly IEnumerable<SubCategory> _entities;

        public SubCategoriesInitializer()
        {
            string guidBasis = "00000000-0000-0000-0000-00000000000";

            var entities = new List<SubCategory>
                {
                    new SubCategory
                    {
                        Id = Guid.Parse(guidBasis + "1").ToString(),
                        Name = "Процессоры"
                    },
                    new SubCategory
                    {
                        Id = Guid.Parse(guidBasis + "2").ToString(),
                        Name = "Материские платы"
                    },
                    new SubCategory
                    {
                        Id = Guid.Parse(guidBasis + "3").ToString(),
                        Name = "Видеокарты"
                    },
                };

            _entities = entities.AsReadOnly();
        }

        public IEnumerable<SubCategory> Entities => _entities;
    }
}
