using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_Objects.DTO
{
    internal class HorseMaxSpeedInfo
    {
        public int Id { get; set; }
        public string? Breed { get; set; }
        public string? Nickname { get; set; }
        public double MaxSpeed { get; set; }

        public override string ToString()
        {
            return $"{Id}.{Nickname} | Breed: {Breed} | Max speed: {MaxSpeed}";
        }
    }
}
