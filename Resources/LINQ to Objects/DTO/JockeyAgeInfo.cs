namespace LINQ_to_Objects.DTO
{
    internal class JockeyAgeInfo
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public double Age { get; set; }

        public override string ToString()
        {
            return $"{Id}.{FullName} - {Age} year(s)";
        }
    }
}
