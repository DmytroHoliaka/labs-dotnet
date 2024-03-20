namespace LINQ_to_Objects.DTO
{
    internal class JockeyCountryInfo
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Country { get; set; }


        public override string ToString()
        {
            return $"{Id}.{FullName} - {Country}";
        }
    }
}
