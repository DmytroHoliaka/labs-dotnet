using System.Xml.Serialization;

namespace LINQ_to_XML.Entities
{
    [Serializable]
    public class Jockey
    {
        [XmlAttribute]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? MiddleName { get; set; }
        public string? Pseudonym { get; set; }
        public DateTime BirthDate { get; set; }

        public int AddressId { get; set; }

        public override string ToString()
        {
            return
               $"""
                Id: {Id}
                FirstName: {FirstName}
                SecondName: {SecondName}
                MiddleName: {MiddleName}
                Pseudonym: {Pseudonym}
                BirthDate: {BirthDate}
                """;
        }
    }
}
