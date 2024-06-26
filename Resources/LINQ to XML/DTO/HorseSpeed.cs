﻿namespace LINQ_to_XML.DTO
{
    internal class HorseSpeed
    {
        public int Id { get; set; }
        public string? Nickname { get; set; }
        public double MaxSpeed { get; set; }

        public override string ToString()
        {
            return $"#{Id} | Nickname: {Nickname} | Max speeed: {MaxSpeed}";
        }
    }
}
