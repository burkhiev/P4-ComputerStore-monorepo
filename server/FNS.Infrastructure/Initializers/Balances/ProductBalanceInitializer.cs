using FNS.ContextsInfrastructure.Initializers;
using FNS.ContextsInfrastructure.Initializers.Products;
using FNS.Domain.Models.Balances;

namespace FNS.Infrastructure.Initializers.Balances
{
    internal sealed class ProductBalanceInitializer : IDataInitializer<ProductBalance>
    {
        private readonly IEnumerable<ProductBalance> _productsBalances;

        public ProductBalanceInitializer()
        {
            var products = new ProductsInitializer().Entities.ToArray();

            string guidBasis = "00000000-0000-0000-0000-00000000000";

            var entities = new List<ProductBalance>
            {
                new ProductBalance 
                {
                    Id = Guid.Parse(guidBasis + "1").ToString(),
                    Amount = 4,
                    ProductId = products[0].Id,
                },
                new ProductBalance
                {
                    Id = Guid.Parse(guidBasis + "2").ToString(),
                    Amount = 10,
                    ProductId = products[1].Id,
                },
                new ProductBalance
                {
                    Id = Guid.Parse(guidBasis + "3").ToString(),
                    Amount = 3,
                    ProductId = products[2].Id,
                },
                new ProductBalance
                {
                    Id = Guid.Parse(guidBasis + "4").ToString(),
                    Amount = 5,
                    ProductId = products[3].Id,
                },
            };

            _productsBalances = entities.AsReadOnly();
        }

        public IEnumerable<ProductBalance> Entities => _productsBalances;
    }
}
