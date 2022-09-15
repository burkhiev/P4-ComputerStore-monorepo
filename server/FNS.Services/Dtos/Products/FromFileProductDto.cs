using System.Text;

namespace FNS.Services.Dtos.Products
{
    public sealed class FromFileProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductCode { get; set; }
        public decimal Price { get; set; }
        public string? SubCategoryName { get; set; }
        public string Img { get; set; }
        public string ImgExtension { get; set; }
        public List<FromFileCharacteristicDto> OwnAttributes { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine();

            sb.AppendLine($"  {nameof(Name)}:            {Name}");
            sb.AppendLine($"  {nameof(Description)}:     {Description}");
            sb.AppendLine($"  {nameof(ProductCode)}:     {ProductCode}");
            sb.AppendLine($"  {nameof(Price)}:           {Price}");
            sb.AppendLine($"  {nameof(OwnAttributes)}:");

            foreach(var attr in OwnAttributes ?? Enumerable.Empty<FromFileCharacteristicDto>())
            {
                sb.AppendLine();
                sb.AppendLine($"    {nameof(attr.Group)}: {attr.Group}");
                sb.AppendLine($"    {nameof(attr.Name)}: {attr.Name}");
                sb.AppendLine($"    {nameof(attr.Value)}: {attr.Value}");
                sb.AppendLine();
            }

            sb.AppendLine();

            return sb.ToString();
        }
    }
}
