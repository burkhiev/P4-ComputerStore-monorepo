using NodaTime;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FNS.Presentation.Utilities.Converters
{
    public sealed class InstantConverter : JsonConverter<Instant>
    {
        public override Instant Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var dateTime = DateTime.Parse(reader.GetString()!);
            var result = Instant.FromDateTimeUtc(dateTime);
            return result;
        }

        public override void Write(Utf8JsonWriter writer, Instant value, JsonSerializerOptions options)
        {
            var dateTime = value.ToDateTimeUtc();
            writer.WriteStringValue(dateTime.ToString("O", CultureInfo.InvariantCulture));
        }
    }
}
