namespace FNS.Services.Dtos.Products
{
    public sealed record ProductDto(
        Guid Id,
        string Name,
        decimal Price
    ) : DtoBase;
}
