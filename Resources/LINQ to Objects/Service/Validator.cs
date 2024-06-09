using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_Objects.Service
{
    internal static class Validator
    {
        public static bool IsInRange(this int number, int min, int max)
        {
            if (number < min || number > max)
            {
                return false;
            }

            return true;
        }

        public static bool IsValid(this string? line)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                return false;
            }

            return int.TryParse(line, out int queryNumber);
        }
    }
}
