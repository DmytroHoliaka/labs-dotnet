namespace LINQ_to_Objects.Entities
{
    internal class Address
    {
        public int Id { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Area { get; set; }
        public string? District { get; set; }
        public string? PostalCode { get; set; }
        public string? Street { get; set; }
        public int BuildingNumber { get; set; }
    }
}
