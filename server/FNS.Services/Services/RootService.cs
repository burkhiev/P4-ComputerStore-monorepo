using FNS.Domain.Repositories;
using FNS.Services.Abstractions;
using FNS.Services.Abstractions.Balances;
using FNS.Services.Abstractions.Indentity;
using FNS.Services.Abstractions.Products;
using FNS.Services.Abstractions.SalesReceipts;
using FNS.Services.Abstractions.ShoppingCarts;
using FNS.Services.Services.Balances;
using FNS.Services.Services.Identity;
using FNS.Services.Services.Products;
using FNS.Services.Services.Sales;
using FNS.Services.Services.ShoppingCarts;

namespace FNS.Services.Services
{
    public sealed class RootService : IRootService
    {
        private readonly Lazy<IProductsService> _productsService;
        private readonly Lazy<IShoppingCartService> _shoppingCartService;
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<ISalesReceiptService> _salesReceiptService;
        private readonly Lazy<IProductsBalanceService> _productsBalanceService;

        public RootService(IRootRepository rootRepository)
        {
            _productsService = new Lazy<IProductsService>(() => new ProductService(rootRepository));
            _shoppingCartService = new Lazy<IShoppingCartService>(() => new ShoppingCartService(rootRepository));
            _userService = new Lazy<IUserService>(() => new UserService(rootRepository));
            _salesReceiptService = new Lazy<ISalesReceiptService>(() => new SaleService(rootRepository));
            _productsBalanceService = new Lazy<IProductsBalanceService>(() => new ProductsBalanceService(rootRepository));
        }

        public IProductsService ProductsService => _productsService.Value;

        public IShoppingCartService ShoppingCartService => _shoppingCartService.Value;

        public IUserService UserService => _userService.Value;

        public ISalesReceiptService SalesReceiptService => _salesReceiptService.Value;

        public IProductsBalanceService ProductsBalanceService => _productsBalanceService.Value;
    }
}
