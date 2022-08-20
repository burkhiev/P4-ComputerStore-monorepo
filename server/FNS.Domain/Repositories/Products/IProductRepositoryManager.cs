namespace FNS.Domain.Repositories.Products
{
    public interface IProductRepositoryManager
    {
        IProductRepository ProductRepository { get; }
        IProductAttributeRepository ProductAttributeRepository { get; }
        IProductAttributeValueRepository ProductWithAttributeValuesRepository { get; }
        IPriceRepository PriceRepository { get; }
        ISubCategoryRepository SubCategoryRepository { get; }
    }
}
