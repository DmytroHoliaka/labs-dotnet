namespace LINQ_to_XML.DTO
{
    internal class RaceInfo
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"#{Id} | Number: {Number} | Start date: {Date}";
        }
    }
}
