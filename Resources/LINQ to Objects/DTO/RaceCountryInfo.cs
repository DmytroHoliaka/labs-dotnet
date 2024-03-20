namespace LINQ_to_Objects.DTO
{
    internal class RaceCountryInfo
    {
        public int Id {get;set;}
        public int Number{get;set;}
        public string? Country{get;set;}

        public override string ToString()
        {
            return $"{Id}.{Number} - {Country}";
        }
    }
}
