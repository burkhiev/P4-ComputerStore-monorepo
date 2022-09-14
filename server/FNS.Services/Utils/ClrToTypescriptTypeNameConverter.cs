namespace FNS.Services.Utils
{
    /// <summary>
    /// Класс используемый для быстрого получения имен базовых 
    /// типов Typescript, для их аналогов из CLR.
    /// </summary>
    public static class ClrToTypescriptTypeNameConverter
    {
        public const string Number = "number";
        public const string String = "string";
        public const string Boolean = "boolean";
        public const string Any = "any";

        /// <summary>
        /// <para>
        /// Позволяет для строкового имени типа CLR получить соответствующее имя типа в Typescript.
        /// Работает корректно только для строк, чисел и булевых значений.</para>
        /// <para>
        /// Для всех остальных типов возвращает any.
        /// </para>
        /// </summary>
        /// <param name="clrTypeName">Имя типа в CLR.</param>
        /// <returns>Имя типа в Typescript.</returns>
        public static string GetTypescriptTypeName(string clrTypeName)
        {
            if(IsNumberTypeName(clrTypeName))
            {
                return Number;
            }


            if(clrTypeName == typeof(string).Name)
            {
                return String;
            }
            else if(clrTypeName == typeof(bool).Name)
            {
                return Boolean;
            }
            else
            {
                return Any;
            }
        }

        /// <summary>
        /// Определяет, является ли тип CLR, указанный в строковом виде, числом в Typescript.
        /// </summary>
        /// <param name="clrTypeName">Имя типа в CLR.</param>
        /// <returns><see cref="true"/> если это число в Typescript, иначе - <see cref="false"/>.</returns>
        public static bool IsNumberTypeName(string clrTypeName)
        {
            bool isNumberTypeName =
                clrTypeName.Equals(typeof(sbyte).Name, StringComparison.OrdinalIgnoreCase)
                || clrTypeName.Equals(typeof(byte).Name, StringComparison.OrdinalIgnoreCase)
                || clrTypeName.Equals(typeof(short).Name, StringComparison.OrdinalIgnoreCase)
                || clrTypeName.Equals(typeof(ushort).Name, StringComparison.OrdinalIgnoreCase)
                || clrTypeName.Equals(typeof(int).Name, StringComparison.OrdinalIgnoreCase)
                || clrTypeName.Equals(typeof(uint).Name, StringComparison.OrdinalIgnoreCase)
                || clrTypeName.Equals(typeof(long).Name, StringComparison.OrdinalIgnoreCase)
                || clrTypeName.Equals(typeof(ulong).Name, StringComparison.OrdinalIgnoreCase)
                || clrTypeName.Equals(typeof(nint).Name, StringComparison.OrdinalIgnoreCase)
                || clrTypeName.Equals(typeof(nuint).Name, StringComparison.OrdinalIgnoreCase)
                || clrTypeName.Equals(typeof(float).Name, StringComparison.OrdinalIgnoreCase)
                || clrTypeName.Equals(typeof(double).Name, StringComparison.OrdinalIgnoreCase)
                || clrTypeName.Equals(typeof(decimal).Name, StringComparison.OrdinalIgnoreCase);

            return isNumberTypeName;
        }
    }
}
