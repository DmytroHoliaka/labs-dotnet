using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_XML.Extensions
{
    internal static class StringExtensions
    {
        public static int ParseToInt(this string value)
        {
            return int.TryParse(value, out int parsed)
                ? parsed : int.MinValue;
        }
    }
}
