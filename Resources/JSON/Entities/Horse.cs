using Json.FileManagement;

namespace Json.Entities
{
    public class Horse
    {
        public int Id { get; set; }
        public string? Breed { get; set; }
        public string? Nickname { get; set; }
        public int Age { get; set; }

        public List<Participant>? Participants { get; set; }
        public List<Caretaker>? Caretakers { get; set; }

        public override string ToString()
        {
            return ObjectSerializer.Serialize(this);
        }
    }
}
