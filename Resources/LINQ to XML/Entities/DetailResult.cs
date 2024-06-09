using System.Xml.Serialization;

namespace LINQ_to_XML.Entities
{
    [Serializable]
    public class DetailResult
    {
        [XmlAttribute]
        public int Id { get; set; }
        public int Place { get; set; }
        public int Duration { get; set; }
        public double MaxSpeed { get; set; }

        public int ParticipantId { get; set; }

        public override string ToString()
        {
            return
               $"""
                Id: {Id}
                Place: {Place}
                Duration: {Duration}
                MaxSpeed: {MaxSpeed}
                ParticipantId: {ParticipantId}
                """;
        }
    }
}