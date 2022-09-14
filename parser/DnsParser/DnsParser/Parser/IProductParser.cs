using FNS.Services.Dtos.Products;

namespace DnsParser.Parser
{
    internal interface IProductParser
    {
        List<FromFileProductDto> Parse();
    }
}
