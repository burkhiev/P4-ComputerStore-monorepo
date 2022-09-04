using FNS.Domain.Models.ShoppingCarts;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos.ShoppingCarts;

namespace FNS.Services.Abstractions.ShoppingCarts
{
    public interface IShoppingCartService : IServiceBase<ShoppingCart>
    {
        public AppOpResult<IEnumerable<ShoppingCartDto>> GetAll();
        public Task<AppOpResult<ShoppingCartWithAdditionalInfoDto>> GetByIdWithAdditionalInfoAsync(string id, CancellationToken ct = default);
        public Task<AppOpResult<ShoppingCartWithAdditionalInfoDto?>> GetByUserIdAsync(string userId, CancellationToken ct = default);
    }
}
