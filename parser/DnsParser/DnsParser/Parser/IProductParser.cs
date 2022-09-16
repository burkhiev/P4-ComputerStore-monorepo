using FNS.Services.Dtos.Products;

namespace DnsParser.Parser
{
    internal interface IProductParser
    {
        Task<List<FromFileSubCategoryDto>> ParseSubCategoriesAsync(string subCategoriesUrl, int maxSubCategoriesCount);
        Task<List<FromFileProductDto>> ParseProductsListAsync(string productListUrl, int maxProductsInListCount, string? subCategoryName = null);
        Task<List<FromFileProductDto>> ParseProductsBySubCategoriesAsync(string subCategoriesUrl, int maxSubCategoriesCount, int maxProductsInListCount);
    }
}
