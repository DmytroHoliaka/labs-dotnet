using System.Xml.Serialization;

namespace LINQ_to_XML.Entities
{
    [Serializable]
    public class Caretaker
    {
        [XmlAttribute]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? MiddleName { get; set; }
        public DateTime EmploymentDate { get; set; }
        public int Salary { get; set; }
        public string? Responsibility { get; set; }
        
        public int AddressId { get; set; }
        [XmlArrayItem("HorseId")]
        public List<int>? HorseIds { get; set; }
    }
}
