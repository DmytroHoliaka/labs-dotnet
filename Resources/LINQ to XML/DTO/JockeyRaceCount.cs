namespace LINQ_to_XML.DTO
{
    internal class JockeyRaceCount
    {
        public int Id { get; set; }
        public int RaceCount { get; set; }

        public override string ToString()
        {
            return $"#{Id} | Race count : {RaceCount}";
        }
    }
}
