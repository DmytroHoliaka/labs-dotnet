namespace LINQ_to_XML.DTO
{
    internal class JockeyCountry
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Country { get; set; }

        public override string ToString()
        {
            return $"#{Id} | Name: {FullName} | Country: {Country}";
        }
    }
}
