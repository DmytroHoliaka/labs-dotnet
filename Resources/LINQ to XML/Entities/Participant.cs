using System.Xml.Serialization;

namespace LINQ_to_XML.Entities
{
    [Serializable]
    public class Participant
    {
        [XmlAttribute]
        public int Id { get; set; }
        public int Number { get; set; }

        public int JockeyId { get; set; }
        public int HorseId { get; set; }
        public int RaceId { get; set; }
    }
}
