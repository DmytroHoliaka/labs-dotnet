namespace LINQ_to_XML.DTO
{
    internal class JockeyAge
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public double Age { get; set; }

        public override string ToString()
        {
            return $"#{Id} | Name: {FullName} | Age: {Age}";
        }
    }
}
