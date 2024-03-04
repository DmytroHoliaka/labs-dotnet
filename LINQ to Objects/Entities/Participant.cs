namespace LINQ_to_Objects.Entities
{
    internal class Participant
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public int JockeyId { get; set; }
        public int HourseId { get; set; }
        public int RaceId { get; set; }
    }
}
