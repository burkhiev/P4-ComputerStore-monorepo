using FNS.Domain.Repositories;
using FNS.Services.Abstractions;
using FNS.Services.Abstractions.Balances;
using FNS.Services.Abstractions.Indentity;
using FNS.Services.Abstractions.Products;
using FNS.Services.Abstractions.Purchases;
using FNS.Services.Abstractions.SalesReceipts;
using FNS.Services.Abstractions.ShoppingCarts;
using FNS.Services.Services.Balances;
using FNS.Services.Services.Identity;
using FNS.Services.Services.Products;
using FNS.Services.Services.Purchases;
using FNS.Services.Services.Sales;
using FNS.Services.Services.ShoppingCarts;

namespace FNS.Services.Services
{
    public sealed class RootService : IRootService
    {
        private readonly Lazy<IProductsService> _productsService;
        private readonly Lazy<IShoppingCartsService> _shoppingCartService;
        private readonly Lazy<IUsersService> _userService;
        private readonly Lazy<ISalesReceiptsService> _salesReceiptService;
        private readonly Lazy<IProductsBalanceService> _productsBalanceService;
        private readonly Lazy<IPurchasesService> _purchasesService;

        public RootService(IRootRepository rootRepository)
        {
            _productsService = new Lazy<IProductsService>(() => new ProductService(rootRepository));
            _shoppingCartService = new Lazy<IShoppingCartsService>(() => new ShoppingCartService(rootRepository));
            _userService = new Lazy<IUsersService>(() => new UserService(rootRepository));
            _salesReceiptService = new Lazy<ISalesReceiptsService>(() => new SaleService(rootRepository));
            _productsBalanceService = new Lazy<IProductsBalanceService>(() => new ProductsBalanceService(rootRepository));
            _purchasesService = new Lazy<IPurchasesService>(() => new PurchasesService(rootRepository));
        }

        public IProductsService ProductsService => _productsService.Value;

        public IShoppingCartsService ShoppingCartService => _shoppingCartService.Value;

        public IUsersService UserService => _userService.Value;

        public ISalesReceiptsService SalesReceiptService => _salesReceiptService.Value;

        public IProductsBalanceService ProductsBalanceService => _productsBalanceService.Value;

        public IPurchasesService PurchasesService => _purchasesService.Value;
    }
}
