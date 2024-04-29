using Json.FileManagement;

namespace Json.Entities
{
    public class Stadium
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int TrackLength { get; set; }
        public int ParticipantCapacity { get; set; }
        public int AudienceCapacity { get; set; }

        public Address? Address { get; set; }
        public List<Race>? Races { get; set; }

        public override string ToString()
        {
            return ObjectSerializer.Serialize(this);
        }
    }
}
