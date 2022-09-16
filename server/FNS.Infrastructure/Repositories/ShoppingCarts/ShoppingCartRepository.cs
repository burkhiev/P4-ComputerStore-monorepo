using FNS.Contexts.Infrastructure;
using FNS.ContextsInfrastructure.Repositories.Products;
using FNS.Domain.Models.ShoppingCarts;
using FNS.Domain.Repositories.ShoppingCarts;
using Microsoft.EntityFrameworkCore;

namespace FNS.Infrastructure.Repositories.ShoppingCarts
{
    internal sealed class ShoppingCartRepository : RepositoryBase<ShoppingCart>, IShoppingCartRepository
    {
        public ShoppingCartRepository(AppDbContext db) : base(db)
        {
            // do nothing
        }

        public async Task LoadShoppingCartsWithItemsAndProducts(ShoppingCart shoppingCart)
        {
            await Db.ShoppingCarts.Where(c => c.Id == shoppingCart.Id)
                .Include(cart => cart.ShoppingCartItems)
                .ThenInclude(item => item.Product)
                .LoadAsync();
        }
    }
}
