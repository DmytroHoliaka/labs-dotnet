namespace LINQ_to_Objects.Entities
{
    internal class Race
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime StartDate { get; set; }

        public int StadiumId { get; set; }
    }
}
