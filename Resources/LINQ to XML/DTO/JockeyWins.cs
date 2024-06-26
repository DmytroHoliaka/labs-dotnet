﻿namespace LINQ_to_XML.DTO
{
    internal class JockeyWins
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public int WinsCount { get; set; }

        public override string ToString()
        {
            return $"#{Id} | Name: {FullName} | Wins: {WinsCount} time(s)";
        }
    }
}
