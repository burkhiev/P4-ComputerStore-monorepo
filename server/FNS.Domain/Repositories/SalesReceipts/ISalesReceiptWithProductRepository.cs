using FNS.Domain.Models.SalesReceipts;

namespace FNS.Domain.Repositories.SalesReceipts
{
    public interface ISalesReceiptWithProductRepository : IRepositoryBase<SalesReceiptWithProduct>
    {
        Task LoadAdditionalInfoBySalesReceiptId(string salesReceiptId);
        Task LoadAdditionalInfoByUserId(string userId);
    }
}
