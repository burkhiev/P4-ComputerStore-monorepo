namespace FNS.Domain.Utilities.Constants
{
    public static class TypescriptTypeNames
    {
        public const string Number = "number";
        public const string String = "string";
        public const string Boolean = "boolean";
        public const string Array = "array";
        public const string Object = "object";

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
