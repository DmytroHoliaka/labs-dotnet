namespace LINQ_to_Objects.DTO
{
    internal class JockeyStadiumCountry
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? StadiumCountry { get; set; }

        public override string ToString()
        {
            return $"{Id}.{FullName} | Stadium country: {StadiumCountry}";
        }
    }
}
