using FNS.Domain.Models.SalesReceipts;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos.SalesReceipts;

namespace FNS.Services.Abstractions.SalesReceipts
{
    public interface ISalesReceiptService : IServiceBase<SalesReceipt>
    {
        AppOpResult<IEnumerable<SalesReceiptDto>> GetAll();
        Task<AppOpResult<SalesReceiptWithAdditionalInfoDto>> GetWithAdditionalAsync(string id, CancellationToken ct = default);
    }
}
