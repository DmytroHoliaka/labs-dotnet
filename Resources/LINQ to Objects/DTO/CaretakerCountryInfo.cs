namespace LINQ_to_Objects.DTO
{
    internal class CaretakerCountryInfo
    {
        public int Id {get;set;}
        public string? FullName {get;set;}
        public int Salary {get;set;}
        public string? Country {get;set;}

        public override string ToString()
        {
            return $"{Id}.{FullName} | Salary: {Salary} | Country: {Country}";
        }
    }
}
