using LINQ_to_Objects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_Objects.DTO
{
    internal class JockeyWinsInfo
    {
        public int JockeyId {get;set;}
        public string? FullName {get;set;}
        public int WinningCount {get;set;}

        public override string ToString()
        {
            return $"{JockeyId}.{FullName}  -  Wins: {WinningCount}";
        }
    }
}
