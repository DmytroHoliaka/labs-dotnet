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
        
        public IEnumerable<int>? HourseIds { get; set; }
    }
}
