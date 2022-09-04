using FNS.Contexts.Infrastructure;
using FNS.ContextsInfrastructure.Repositories.Products;
using FNS.Domain.Models.ShoppingCarts;
using FNS.Domain.Repositories.ShoppingCarts;

namespace FNS.Infrastructure.Repositories.ShoppingCarts
{
    internal sealed class ShoppingCartItemsRepository : RepositoryBase<ShoppingCartItem>, IShoppingCartItemsRepository
    {
        public ShoppingCartItemsRepository(AppDbContext db) : base(db)
        {
            // do nothing
        }
    }
}
