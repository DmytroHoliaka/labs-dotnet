using Json.FileManagement;

namespace Json.Entities
{
    public class Race
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime StartDate { get; set; }

        public Stadium? Stadium { get; set; }
        public List<Participant>? Participants { get; set; }

        public override string ToString()
        {
            return ObjectSerializer.Serialize(this);
        }
    }
}
