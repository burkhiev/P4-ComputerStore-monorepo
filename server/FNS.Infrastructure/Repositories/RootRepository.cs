using FNS.Domain.Repositories;
using FNS.Domain.Repositories.Products;
using FNS.ContextsInfrastructure.Repositories.Products;
using FNS.Contexts.Infrastructure;
using FNS.Domain.Repositories.ShoppingCarts;
using FNS.Infrastructure.Repositories.ShoppingCarts;
using FNS.Domain.Repositories.Identity;
using FNS.Infrastructure.Repositories.Identity;
using FNS.Domain.Repositories.SalesReceipts;
using FNS.Infrastructure.Repositories.SalesReceipts;
using FNS.Domain.Repositories.Balances;
using FNS.Infrastructure.Repositories.Balances;
using FNS.Infrastructure.Repositories.Purchases;
using FNS.Domain.Repositories.Purchases;

namespace FNS.ContextsInfrastructure.Repositories
{
    public sealed class RootRepository : IRootRepository
    {
        private readonly AppDbContext _db;
        private readonly Lazy<IUsersRepository> _users;
        private readonly Lazy<IProductRepository> _products;
        private readonly Lazy<IProductAttributeRepository> _productAttributes;
        private readonly Lazy<IProductAttributeValueRepository> _productAttributeValues;
        private readonly Lazy<ISubCategoryRepository> _subCategories;
        private readonly Lazy<IShoppingCartRepository> _shoppingCarts;
        private readonly Lazy<IShoppingCartItemsRepository> _shoppingCartItems;
        private readonly Lazy<ISalesReceiptRepository> _salesReceipts;
        private readonly Lazy<ISalesReceiptWithProductRepository> _salesReceiptWithProducts;
        private readonly Lazy<IProductBalanceRepository> _productBalances;
        private readonly Lazy<IPurchaseInvoicesRepository> _purchaseInvoices;
        private readonly Lazy<IPurchaseInvoiceItemsRepository> _purchaseInvoiceItems;

        public RootRepository(AppDbContext db)
        {
            _db = db;
            _users = new Lazy<IUsersRepository>(() => new UsersRepository(_db));
            _products = new Lazy<IProductRepository>(() => new ProductRepository(_db));
            _productAttributes = new Lazy<IProductAttributeRepository>(() => new ProductAttributeRepository(_db));
            _productAttributeValues = new Lazy<IProductAttributeValueRepository>(() => new ProductAttributeValueRepository(_db));
            _subCategories = new Lazy<ISubCategoryRepository>(() => new SubCategoryRepository(_db));
            _shoppingCarts = new Lazy<IShoppingCartRepository>(() => new ShoppingCartRepository(_db));
            _shoppingCartItems = new Lazy<IShoppingCartItemsRepository>(() => new ShoppingCartItemsRepository(_db));
            _salesReceipts = new Lazy<ISalesReceiptRepository>(() => new SalesReceiptRepository(_db));
            _salesReceiptWithProducts = new Lazy<ISalesReceiptWithProductRepository>(() => new SalesReceiptWithProductRepository(_db));
            _productBalances = new Lazy<IProductBalanceRepository>(() => new ProductBalancesRepository(_db));
            _purchaseInvoices = new Lazy<IPurchaseInvoicesRepository>(() => new PurchaseInvoicesRepository(_db));
            _purchaseInvoiceItems = new Lazy<IPurchaseInvoiceItemsRepository>(() => new PurchaseInvoiceItemsRepository(_db));
        }

        public AppDbContext Db => _db;

        public IUsersRepository Users => _users.Value;

        public IProductRepository Products => _products.Value;

        public IProductAttributeRepository ProductAttributes => _productAttributes.Value;

        public IProductAttributeValueRepository ProductWithAttributeValues => _productAttributeValues.Value;

        public ISubCategoryRepository SubCategories => _subCategories.Value;

        public IShoppingCartItemsRepository ShoppingCartItems => _shoppingCartItems.Value;

        public IShoppingCartRepository ShoppingCarts => _shoppingCarts.Value;

        public ISalesReceiptRepository SalesReceipts => _salesReceipts.Value;

        public ISalesReceiptWithProductRepository SalesReceiptWithProducts => _salesReceiptWithProducts.Value;

        public IProductBalanceRepository ProductBalances => _productBalances.Value;

        public IPurchaseInvoicesRepository PurchaseInvoices => _purchaseInvoices.Value;

        public IPurchaseInvoiceItemsRepository PurchaseInvoiceItems => _purchaseInvoiceItems.Value;

        public async Task<int> SaveChangesAsync(CancellationToken ct = default)
        {
            var result = await Db.SaveChangesAsync(ct);
            return result;
        }
    }
}
