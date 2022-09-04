using FNS.Domain.Models.Purchases;
using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos.Purchases;

namespace FNS.Services.Abstractions.Purchases
{
    public interface IPurchasesService
    {
        AppOpResult<IEnumerable<PurchaseInvoiceDto>> GetAllInvoices();
        Task<AppOpResult<IEnumerable<PurchaseInvoiceItemDto>>> GetInvoiceItemsByInvoiceId(string invoiceId);
    }
}
