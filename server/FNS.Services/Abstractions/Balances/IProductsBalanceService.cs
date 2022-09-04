using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos.Balances;

namespace FNS.Services.Abstractions.Balances
{
    public interface IProductsBalanceService
    {
        AppOpResult<IEnumerable<ProductBalanceDto>> GetAll();
        Task<AppOpResult<ProductBalanceDto>> GetByIdAsync(string productBalanceId);
        Task<AppOpResult<IEnumerable<ProductBalanceDto>>> GetByProductIdAsync(string productId);
    }
}
