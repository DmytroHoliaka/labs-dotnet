using Json.Entities;
using Json.FileManagement;

namespace Json.DataCollector
{
    public class DataContext
    {
        public List<Address> Addresses { get; set; } = [];
        public List<Caretaker> Caretakers { get; set; } = [];
        public List<DetailResult> DetailResults { get; set; } = [];
        public List<Horse> Horses { get; set; } = [];
        public List<Jockey> Jockeys { get; set; } = [];
        public List<Participant> Participants { get; set; } = [];
        public List<Race> Races { get; set; } = [];
        public List<Stadium> Stadiums { get; set; } = [];

        public override string ToString()
        {
            return ObjectSerializer.Serialize(this);
        }
    }
}
