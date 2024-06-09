using System.Xml.Serialization;

namespace LINQ_to_XML.Entities
{
    [Serializable]
    public class Race
    {
        [XmlAttribute]
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime StartDate { get; set; }

        public int StadiumId { get; set; }

        public override string ToString()
        {
            return
               $"""
                Id: {Id}
                Number: {Number}
                StartDate: {StartDate}
                StadiumId: {StadiumId}
                """;
        }
    }
}
