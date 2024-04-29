using Json.FileManagement;

namespace Json.Entities
{
    public class Participant
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public Jockey? Jockey { get; set; }
        public Horse? Horse { get; set; }
        public DetailResult? DetailResult { get; set; }
        public Race? Race { get; set; }

        public override string ToString()
        {
            return ObjectSerializer.Serialize(this);
        }
    }
}
