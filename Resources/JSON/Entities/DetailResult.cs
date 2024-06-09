using Json.FileManagement;

namespace Json.Entities
{
    public class DetailResult
    {
        public int Id { get; set; }
        public int Place { get; set; }
        public int Duration { get; set; }
        public double MaxSpeed { get; set; }

        public Participant? Participant { get; set; }

        public override string ToString()
        {
            return ObjectSerializer.Serialize(this);
        }
    }
}