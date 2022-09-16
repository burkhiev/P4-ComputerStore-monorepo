namespace DnsParser.Utilities
{
    public interface IFileWriter
    {
        Task WriteToFileAsync<T>(string path, string baseFileName, T obj);
    }
}
