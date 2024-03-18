using LINQ_to_XML.Entities;
using System.Xml.Serialization;

namespace LINQ_to_XML.DataCollector
{
    [XmlRoot("Data")]
    public class DataContext
    {
        public List<Address> Addresses;
        public List<Caretaker> Caretakers;
        public List<DetailResult> DetailResults;
        public List<Horse> Horses;
        public List<Jockey> Jockeys;
        public List<Participant> Participants;
        public List<Race> Races;
        public List<Stadium> Stadiums;

        public DataContext()
        {
            Addresses = [];
            Caretakers = [];
            DetailResults = [];
            Horses = [];
            Jockeys = [];
            Participants = [];
            Races = [];
            Stadiums = [];
        }
    }
}
