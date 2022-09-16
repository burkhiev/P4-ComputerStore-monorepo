namespace DnsParser.Utilities
{
    internal static class StringExtensions
    {
        
        /// <summary>
        /// Проверяет, имеет ли строка окончание, соответствующее расширениям ".jpg", ".jpeg", ".png".
        /// </summary>
        /// <param name="str">Проверяемая строка</param>
        /// <returns>true - если соответствует, false - если нет.</returns>
        public static bool HasImageExtension(this string str)
        {
            string? ext = Path.GetExtension(str).Trim();

            if(string.IsNullOrWhiteSpace(ext))
            {
                return false;
            }

            bool isImage = (ext.Equals(".jpg") || ext.Equals(".jpeg") || ext.Equals(".png"));

            return isImage;
        }
    }
}
