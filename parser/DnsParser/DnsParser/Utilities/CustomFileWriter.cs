using System.Text.Encodings.Web;
using System.Text.Json;

namespace DnsParser.Utilities
{
    internal sealed class CustomFileWriter : IFileWriter
    {
        public async Task WriteToFileAsync<T>(string dirPath, string baseFileName, T obj)
        {
            var now = DateTime.Now;

            string fileAppendix = $"{now.Year}-{now.Month}-{now.Day}--{now.Hour}-{now.Minute}-{now.Second}";

            string path = @$"{dirPath}\{baseFileName}-{fileAppendix}.json";


            using(var fs = new FileStream(path, FileMode.CreateNew))
            {
                JsonSerializerOptions options = new()
                {
                    AllowTrailingCommas = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = true,
                    DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                };

                await JsonSerializer.SerializeAsync(fs, obj, options);
            }
        }
    }
}
