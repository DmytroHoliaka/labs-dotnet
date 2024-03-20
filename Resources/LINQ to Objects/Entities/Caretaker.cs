namespace LINQ_to_Objects.Entities
{
    internal class Caretaker
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? MiddleName { get; set; }
        public DateTime EmploymentDate { get; set; }
        public int Salary { get; set; }
        public string? Responsibility { get; set; }
        
        public int AddressId { get; set; }
        public IEnumerable<int>? HorseIds { get; set; }
    }
}
