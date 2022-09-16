using FNS.Domain.Models.Purchases;

namespace FNS.Domain.Repositories.Purchases
{
    public interface IPurchaseInvoicesRepository : IRepositoryBase<PurchaseInvoice>
    {
        Task LoadItemsWithProductsAsync(string invoiceId);
    }
}
