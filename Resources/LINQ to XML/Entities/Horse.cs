using System.Xml.Serialization;

namespace LINQ_to_XML.Entities
{
    [Serializable]
    public class Horse
    { 
        [XmlAttribute]
        public int Id { get; set; }
        public string? Breed { get; set; }
        public string? Nickname { get; set; }
        public int Age { get; set; }

        [XmlArrayItem("CaretakerId")]
        public List<int>? CaretakerIds { get; set; }

        public override string ToString()
        {
            return
               $"""
                Id: {Id}
                Breed: {Breed}
                Nickname: {Nickname}
                Age: {Age}
                CaretakerIds: {string.Join(", ", CaretakerIds ?? Enumerable.Empty<int>())}
                """;
        }
    }
}
