using System.Text;

namespace FNS.Services.Utilities.ExtensionMethods
{
    public static class StringExtensions
    {
        public static string GetUniqueFileName(this string str)
        {
            if(string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentNullException(nameof(str));
            }

            var newStr = str.GetTransliterationFromRussianToEnglish();
            //newStr = newStr + "_" + Guid.NewGuid().ToString().Substring(0, 6);

            return newStr;
        }

        public static string GetTransliterationFromRussianToEnglish(this string str)
        {
            if(string.IsNullOrWhiteSpace(str))
            {
                return str;
            }

            str = str.ToLowerInvariant();
            var newString = new StringBuilder();

            for(int i = 0; i < str.Length; i++)
            {
                string ch = str.Substring(i, 1);

                string engCh = ch switch
                {
                    " " => "_",
                    "а" => "a",
                    "б" => "b",
                    "в" => "v",
                    "г" => "g",
                    "д" => "d",
                    "е" => "e",
                    "ё" => "e",
                    "ж" => "zh",
                    "з" => "z",
                    "и" => "i",
                    "й" => "i",
                    "к" => "k",
                    "л" => "l",
                    "м" => "m",
                    "н" => "n",
                    "о" => "o",
                    "п" => "p",
                    "р" => "r",
                    "с" => "s",
                    "т" => "t",
                    "у" => "u",
                    "ф" => "f",
                    "х" => "kh",
                    "ц" => "ts",
                    "ч" => "ch",
                    "ш" => "sh",
                    "щ" => "shch",
                    "ъ" => "ie",
                    "ы" => "y",
                    "ь" => "",
                    "э" => "e",
                    "ю" => "iu",
                    "я" => "ia",
                    _ => ch
                };

                newString.Append(engCh);
            }

            return newString.ToString();
        }
    }
}
