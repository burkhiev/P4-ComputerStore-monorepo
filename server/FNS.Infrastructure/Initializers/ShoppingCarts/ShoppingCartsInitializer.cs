using FNS.ContextsInfrastructure.Initializers;
using FNS.Domain.Models.ShoppingCarts;
using FNS.Infrastructure.Initializers.Identity;

namespace FNS.Infrastructure.Initializers.ShoppingCarts
{
    internal sealed class ShoppingCartsInitializer : IDataInitializer<ShoppingCart>
    {
        private readonly IEnumerable<ShoppingCart> _entities;

        public ShoppingCartsInitializer()
        {
            var users = new UserInitializer().Entities.ToArray();

            string guidBasis1 = "00000000-0000-0000-0000-00000000000";

            var carts = new List<ShoppingCart>
            {
                new ShoppingCart
                {
                    Id = Guid.Parse(guidBasis1 + "1").ToString(),
                    UserId = users[0].Id,
                },
                new ShoppingCart
                {
                    Id = Guid.Parse(guidBasis1 + "2").ToString(),
                    UserId = users[1].Id,
                },
                new ShoppingCart
                {
                    Id = Guid.Parse(guidBasis1 + "3").ToString(),
                    UserId = users[2].Id,
                },
            };

            _entities = carts.AsReadOnly();
        }

        public IEnumerable<ShoppingCart> Entities => _entities;
    }
}
