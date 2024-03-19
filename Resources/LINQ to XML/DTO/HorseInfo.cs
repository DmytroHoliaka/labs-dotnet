using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_XML.DTO
{
    internal class HorseInfo
    {
        public int Id {get;set;}
        public string? Nickname {get;set;}
        public string? Breed { get; set; }

        public override string ToString()
        {
            return $"#{Id} | Nickname: {Nickname} | Breed: {Breed}";
        }
    }
}
