using Json.FileManagement;

namespace Json.Entities
{
    public class Jockey
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? MiddleName { get; set; }
        public string? Pseudonym { get; set; }
        public DateTime BirthDate { get; set; }

        public Address? Address { get; set; }
        public List<Participant>? Participants { get; set; }

        public override string ToString()
        {
            return ObjectSerializer.Serialize(this);
        }
    }
}