using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos.Balances;

namespace FNS.Services.Abstractions.Balances
{
    public interface IProductsBalanceService
    {
        OpResult<IEnumerable<ProductBalanceDto>> GetAll();
        Task<OpResult<ProductBalanceDto>> GetByIdAsync(string productBalanceId);
        Task<OpResult<IEnumerable<ProductBalanceDto>>> GetByProductIdAsync(string productId);
    }
}
