using FNS.ContextsInfrastructure.Initializers;
using FNS.Domain.Models.Products;

namespace FNS.Infrastructure.Initializers.Products
{
    internal sealed class ProductAttributeGroupsInitializer : IDataInitializer<ProductAttributeGroup>
    {
        private readonly IEnumerable<ProductAttributeGroup> _entities;

        public ProductAttributeGroupsInitializer()
        {
            string guidBasis1 = "00000000-0000-0000-0000-00000000000";

            var entities = new List<ProductAttributeGroup>
            {
                new ProductAttributeGroup { Id = Guid.Parse(guidBasis1 + "1").ToString(), Name = "Общие параметры" },
                new ProductAttributeGroup { Id = Guid.Parse(guidBasis1 + "2").ToString(), Name = "Параметры процессора" },
            };

            _entities = entities.AsReadOnly();
        }

        public IEnumerable<ProductAttributeGroup> Entities => _entities;
    }
}
