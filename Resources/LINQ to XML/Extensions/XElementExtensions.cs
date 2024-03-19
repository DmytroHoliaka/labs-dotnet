using System.Xml.Linq;

namespace LINQ_to_XML.Extensions
{
    internal static class XElementExtensions
    {
        public static int ParseAttributeToInt(this XElement xElement, string tagName)
        {
            return int.TryParse(xElement.Attribute(tagName)?.Value, out int parsed)
                ? parsed : int.MinValue;
        }

        public static int ParseElementToInt(this XElement xElement, string tagName)
        {
            return int.TryParse(xElement.Element(tagName)?.Value, out int parsed)
                ? parsed : int.MinValue;
        }

        public static double ParseElementToDouble(this XElement xElement, string tagName)
        {
            return double.TryParse(xElement.Element(tagName)?.Value, out double parsed)
                ? parsed : double.MinValue;
        }

        public static List<int> ParseElementToList(this XElement xElement, string tagName)
        {
            return xElement.Element(tagName)?.Elements()
                .Select(e => int.TryParse(e.Value, out int parsed)
                                ? parsed : int.MinValue)
                .ToList() ?? [];
        }

        public static DateTime ParseElementToDateTime(this XElement xElement, string tagName)
        {
            return DateTime.TryParse(xElement.Element(tagName)?.Value, out DateTime parsed)
                ? parsed : DateTime.MinValue;
        }

        public static string GetElementValue(this XElement xElement, string tagName)
        {
            return xElement.Element(tagName)?.Value ?? "<unknown>";
        }
    }
}
