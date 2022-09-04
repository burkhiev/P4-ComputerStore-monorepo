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

namespace FNS.ContextsInfrastructure.Repositories
{
    public sealed class RootRepository : IRootRepository
    {
        private readonly AppDbContext _db;
        private readonly Lazy<IUsersRepository> _usersRepository;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<IProductAttributeRepository> _productAttributeRepository;
        private readonly Lazy<IProductAttributeValueRepository> _productAttributeValueRepository;
        private readonly Lazy<ISubCategoryRepository> _subCategoryRepository;
        private readonly Lazy<IShoppingCartRepository> _shoppingCartRepository;
        private readonly Lazy<IShoppingCartItemsRepository> _shoppingCartItemsRepository;
        private readonly Lazy<ISalesReceiptRepository> _salesReceiptRepository;
        private readonly Lazy<ISalesReceiptWithProductRepository> _salesReceiptWithProductRepository;
        private readonly Lazy<IProductBalanceRepository> _productBalanceRepository;

        public RootRepository(AppDbContext db)
        {
            _db = db;
            _usersRepository = new Lazy<IUsersRepository>(() => new UsersRepository(_db));
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(_db));
            _productAttributeRepository = new Lazy<IProductAttributeRepository>(() => new ProductAttributeRepository(_db));
            _productAttributeValueRepository = new Lazy<IProductAttributeValueRepository>(() => new ProductAttributeValueRepository(_db));
            _subCategoryRepository = new Lazy<ISubCategoryRepository>(() => new SubCategoryRepository(_db));
            _shoppingCartRepository = new Lazy<IShoppingCartRepository>(() => new ShoppingCartRepository(_db));
            _shoppingCartItemsRepository = new Lazy<IShoppingCartItemsRepository>(() => new ShoppingCartItemsRepository(_db));
            _salesReceiptRepository = new Lazy<ISalesReceiptRepository>(() => new SalesReceiptRepository(_db));
            _salesReceiptWithProductRepository = new Lazy<ISalesReceiptWithProductRepository>(() => new SalesReceiptWithProductRepository(_db));
            _productBalanceRepository = new Lazy<IProductBalanceRepository>(() => new ProductBalancesRepository(_db));
        }

        public AppDbContext Db => _db;

        public IUsersRepository UsersRepository => _usersRepository.Value;

        public IProductRepository ProductRepository => _productRepository.Value;

        public IProductAttributeRepository ProductAttributeRepository => _productAttributeRepository.Value;

        public IProductAttributeValueRepository ProductWithAttributeValuesRepository => _productAttributeValueRepository.Value;

        public ISubCategoryRepository SubCategoryRepository => _subCategoryRepository.Value;

        public IShoppingCartItemsRepository ShoppingCartItemsRepository => _shoppingCartItemsRepository.Value;

        public IShoppingCartRepository ShoppingCartRepository => _shoppingCartRepository.Value;

        public ISalesReceiptRepository SalesReceiptRepository => _salesReceiptRepository.Value;

        public ISalesReceiptWithProductRepository SalesReceiptWithProductRepository => _salesReceiptWithProductRepository.Value;

        public IProductBalanceRepository ProductBalanceRepository => _productBalanceRepository.Value;

        public async Task<int> SaveChangesAsync(CancellationToken ct = default)
        {
            var result = await Db.SaveChangesAsync(ct);
            return result;
        }
    }
}
