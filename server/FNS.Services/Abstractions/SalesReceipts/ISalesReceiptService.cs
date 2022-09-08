using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos.SalesReceipts;

namespace FNS.Services.Abstractions.SalesReceipts
{
    public interface ISalesReceiptsService
    {
        AppOpResult<IEnumerable<SalesReceiptDto>> GetAll();
        Task<AppOpResult<SalesReceiptWithAdditionalInfoDto>> GetWithAdditionalInfoAsync(string id);
        Task<AppOpResult<IEnumerable<SalesReceiptWithAdditionalInfoDto>>> GetByUserIdAsync(string userId);
        Task<AppOpResult<SaleSuccessResultDto>> MakeSaleAsync(SaleDto saleInfo);
    }
}
