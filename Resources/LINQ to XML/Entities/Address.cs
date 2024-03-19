using System.Xml.Serialization;

namespace LINQ_to_XML.Entities
{
    [Serializable]
    public class Address
    {
        [XmlAttribute]
        public int Id { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Area { get; set; }
        public string? District { get; set; }
        public string? PostalCode { get; set; }
        public string? Street { get; set; }
        public int BuildingNumber { get; set; }

        public override string ToString()
        {
            return
               $"""
                Id: {Id}
                Country: {Country}
                City: {City}
                Area: {Area}
                District: {District}
                PostalCode: {PostalCode}
                Street: {Street}
                BuildingNumber: {BuildingNumber}
                """;
        }
    }
}
