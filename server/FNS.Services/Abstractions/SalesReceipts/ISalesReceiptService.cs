using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos;
using FNS.Services.Dtos.SalesReceipts;

namespace FNS.Services.Abstractions.SalesReceipts
{
    public interface ISalesService
    {
        OpResult<IEnumerable<SalesReceiptDto>> GetAll();
        Task<OpResult<SalesReceiptWithAdditionalInfoDto>> GetWithAdditionalInfoAsync(string id);
        Task<OpResult<IEnumerable<SalesReceiptWithAdditionalInfoDto>>> GetByUserIdAsync(string userId);
        Task<OpResult<SaleSuccessResultDto>> MakeSaleAsync(string userId);
    }
}
