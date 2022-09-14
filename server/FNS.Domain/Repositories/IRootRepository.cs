using FNS.Domain.Repositories.Balances;
using FNS.Domain.Repositories.Identity;
using FNS.Domain.Repositories.Products;
using FNS.Domain.Repositories.Purchases;
using FNS.Domain.Repositories.SalesReceipts;
using FNS.Domain.Repositories.ShoppingCarts;

namespace FNS.Domain.Repositories
{
    public interface IRootRepository : IUnitOfWork
    {
        IUsersRepository Users { get; }
        IProductRepository Products { get; }
        IProductAttributeRepository ProductAttributes { get; }
        IProductAttributeValueRepository ProductWithAttributeValues { get; }
        ISubCategoryRepository SubCategories { get; }
        IShoppingCartItemsRepository ShoppingCartItems { get; }
        IShoppingCartRepository ShoppingCarts { get; }
        ISalesReceiptRepository SalesReceipts { get; }
        ISalesReceiptWithProductRepository SalesReceiptWithProducts { get; }
        IProductBalanceRepository ProductBalances { get; }
        IPurchaseInvoicesRepository PurchaseInvoices { get; }
        IPurchaseInvoiceItemsRepository PurchaseInvoiceItems { get; }
        IRolesRepository Roles { get; }
        IUserRolesRepository UserRoles { get; }
        IProductAttributeGroupRepository ProductAttributeGroups { get; }
    }
}
