using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos.SalesReceipts;

namespace FNS.Services.Abstractions.SalesReceipts
{
    public interface ISalesReceiptsService
    {
        AppOpResult<IEnumerable<SalesReceiptDto>> GetAll();
        Task<AppOpResult<SalesReceiptWithAdditionalInfoDto>> GetWithAdditionalAsync(string id);
        Task<AppOpResult<SaleSuccessResultDto>> MakeSaleAsync(SaleDto saleInfo);
    }
}
