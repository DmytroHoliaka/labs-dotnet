﻿namespace LINQ_to_XML.DTO
{
    internal class RaceHorseCount
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int HorseCount { get; set; }

        public override string ToString()
        {
            return $"#{Id} | Race number: {Number} | Horse count: {HorseCount}";
        }
    }
}
