using FNS.Services.Abstractions.Balances;
using FNS.Services.Abstractions.Indentity;
using FNS.Services.Abstractions.Products;
using FNS.Services.Abstractions.Purchases;
using FNS.Services.Abstractions.SalesReceipts;
using FNS.Services.Abstractions.ShoppingCarts;

namespace FNS.Services.Abstractions
{
    public interface IRootService
    {
        IProductsService ProductsService { get; }
        IShoppingCartsService ShoppingCartService { get; }
        IUsersService UserService { get; }
        ISalesService SalesReceiptService { get; }
        IProductsBalanceService ProductsBalanceService { get; }
        IPurchasesService PurchasesService { get; }
    }
}
