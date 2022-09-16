using FNS.ContextsInfrastructure.Initializers;
using FNS.ContextsInfrastructure.Initializers.Products;
using FNS.Domain.Models.ShoppingCarts;

namespace FNS.Infrastructure.Initializers.ShoppingCarts
{
    internal sealed class ShoppingCartsItemsInitializer : IDataInitializer<ShoppingCartItem>
    {
        private readonly IEnumerable<ShoppingCartItem> _entities;

        public ShoppingCartsItemsInitializer()
        {
            var carts = new ShoppingCartsInitializer().Entities.ToArray();
            var products = new ProductsInitializer().Entities.ToArray();

            string guidBasis1 = "00000000-0000-0000-0000-00000000000";

            var cartItems = new List<ShoppingCartItem>
            {
                new ShoppingCartItem
                {
                    Id = Guid.Parse(guidBasis1 + "1").ToString(),
                    ShoppingCartId = carts[1].Id,
                    ProductId = products[0].Id,
                    Amount = 1,
                },
                new ShoppingCartItem
                {
                    Id = Guid.Parse(guidBasis1 + "2").ToString(),
                    ShoppingCartId = carts[1].Id,
                    ProductId = products[1].Id,
                    Amount = 2,
                },
                new ShoppingCartItem
                {
                    Id = Guid.Parse(guidBasis1 + "3").ToString(),
                    ShoppingCartId = carts[1].Id,
                    ProductId = products[3].Id,
                    Amount = 1,
                },
                new ShoppingCartItem
                {
                    Id = Guid.Parse(guidBasis1 + "4").ToString(),
                    ShoppingCartId = carts[0].Id,
                    ProductId = products[2].Id,
                    Amount = 1,
                },
            };

            _entities = cartItems.AsReadOnly();
        }

        public IEnumerable<ShoppingCartItem> Entities => _entities;
    }
}
