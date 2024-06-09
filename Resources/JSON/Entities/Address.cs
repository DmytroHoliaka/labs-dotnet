using Json.FileManagement;

namespace Json.Entities
{
    public class Address
    {
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
            return ObjectSerializer.Serialize(this);
        }
    }
}
