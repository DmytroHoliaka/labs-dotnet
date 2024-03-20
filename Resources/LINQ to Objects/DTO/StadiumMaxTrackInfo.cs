using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_Objects.DTO
{
    internal class StadiumMaxTrackInfo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int TrackLength { get; set; }

        public override string ToString()
        {
            return $"{Id}.{Name} - {TrackLength} meter(s)";
        }
    }
}
