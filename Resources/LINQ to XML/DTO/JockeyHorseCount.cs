namespace LINQ_to_XML.DTO
{
    internal class JockeyHorseCount
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Nickname { get; set; }
        public int RaceCount { get; set; }

        public override string ToString()
        {
            return $"#{Id} | Name: {FullName} | Nickname: {Nickname} | Race count: {RaceCount}";
        }
    }
}
