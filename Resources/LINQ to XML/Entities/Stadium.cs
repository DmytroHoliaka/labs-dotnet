using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LINQ_to_XML.Entities
{
    [Serializable]
    public class Stadium
    {
        [XmlAttribute]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int TrackLength { get; set; }
        public int ParticipantCapacity { get; set; }
        public int AudienceCapacity { get; set; }
        
        public int AddressId { get; set; }

        public override string ToString()
        {
            return
               $"""
                Id: {Id}
                Name: {Name}
                TrackLength: {TrackLength}
                ParticipantCapacity: {ParticipantCapacity}
                AudienceCapacity: {AudienceCapacity}
                """;
        }
    }
}
