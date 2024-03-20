namespace LINQ_to_XML.DTO
{
    internal class StadiumSpeed
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Speed { get; set; }

        public override string ToString()
        {
            return $"#{Id} | Name: {Name} | Max speed: {Speed}";
        }
    }
}
