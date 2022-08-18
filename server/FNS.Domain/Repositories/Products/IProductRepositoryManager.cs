namespace FNS.Domain.Repositories.Products
{
    public interface IProductRepositoryManager
    {
        IPriceRepository PriceRepository { get; }
        IProductAttributeRepository ProductAttributeRepository { get; }
        IProductRepository ProductRepository { get; }
        IProductWithAttributeValuesRepository ProductWithAttributeValuesRepository { get; }
    }
}
