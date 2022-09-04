using FNS.Domain.Repositories.Balances;
using FNS.Domain.Repositories.Identity;
using FNS.Domain.Repositories.Products;
using FNS.Domain.Repositories.SalesReceipts;
using FNS.Domain.Repositories.ShoppingCarts;

namespace FNS.Domain.Repositories
{
    public interface IRootRepository : IUnitOfWork
    {
        IUsersRepository UsersRepository { get; }
        IProductRepository ProductRepository { get; }
        IProductAttributeRepository ProductAttributeRepository { get; }
        IProductAttributeValueRepository ProductWithAttributeValuesRepository { get; }
        ISubCategoryRepository SubCategoryRepository { get; }
        IShoppingCartItemsRepository ShoppingCartItemsRepository { get; }
        IShoppingCartRepository ShoppingCartRepository { get; }
        ISalesReceiptRepository SalesReceiptRepository { get; }
        ISalesReceiptWithProductRepository SalesReceiptWithProductRepository { get; }
        IProductBalanceRepository ProductBalanceRepository { get; }
    }
}
