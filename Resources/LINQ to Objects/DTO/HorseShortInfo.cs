using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_Objects.DTO
{
    internal class HorseShortInfo
    {
        public int Id { get; set; }
        public string? Nickname { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Id}.{Nickname} - {Age} year(s)";
        }
    }
}
