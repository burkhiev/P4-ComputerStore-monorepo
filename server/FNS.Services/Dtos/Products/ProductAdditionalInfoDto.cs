namespace FNS.Services.Dtos.Products
{
    public sealed record ProductAdditionalInfoDto(
        Guid Id,
        string? Description,
        string ProductCode,
        IDictionary<string, object> SpecificAttributes
    ) : DtoBase;
}
