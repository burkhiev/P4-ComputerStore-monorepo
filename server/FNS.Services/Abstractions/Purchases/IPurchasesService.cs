using FNS.Domain.Utilities.OperationResults;
using FNS.Services.Dtos.Purchases;

namespace FNS.Services.Abstractions.Purchases
{
    public interface IPurchasesService
    {
        Task<OpResult<IEnumerable<PurchaseInvoiceDto>>> GetAllInvoicesAsync();
        Task<OpResult<IEnumerable<PurchaseInvoiceItemWithAdditionalInfoDto>>> GetInvoiceItemsByInvoiceId(string invoiceId);
        Task<OpResult<PurchaseInvoiceDto>> MakePurchaseAsync(PurchaseInvoiceForCreateDto dto);
    }
}
