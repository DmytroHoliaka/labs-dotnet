using Json.FileManagement;

namespace Json.Entities
{
    public class Caretaker
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? MiddleName { get; set; }
        public DateTime EmploymentDate { get; set; }
        public int Salary { get; set; }
        public string? Responsibility { get; set; }

        public Address? Address { get; set; }
        public List<Horse>? Horses { get; set; }

        public override string ToString()
        {
            return ObjectSerializer.Serialize(this);
        }
    }
}
