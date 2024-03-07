namespace LINQ_to_Objects.Entities
{
    internal class DetailResult
    {
        public int Id { get; set; }
        public int Place { get; set; }
        public int Duration { get; set; }
        public double MaxSpeed { get; set; }

        public int ParticipantId { get; set; }
    }
}