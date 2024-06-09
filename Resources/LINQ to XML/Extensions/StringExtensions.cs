namespace LINQ_to_XML.Extensions
{
    internal static class StringExtensions
    {
        public static int ParseToInt(this string? value)
        {
            return int.TryParse(value, out int parsed)
                ? parsed : int.MinValue;
        }
    }
}
