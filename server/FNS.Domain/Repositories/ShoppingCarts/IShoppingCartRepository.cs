using FNS.Domain.Models.ShoppingCarts;

namespace FNS.Domain.Repositories.ShoppingCarts
{
    public interface IShoppingCartRepository : IRepositoryBase<ShoppingCart>
    {
        Task LoadShoppingCartsWithItemsAndProducts(ShoppingCart cart, CancellationToken ct = default);
    }
}
