namespace LINQ_to_Objects.Entities
{
    internal class Stadium
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int TrackLength { get; set; }
        public int ParticipantCapacity { get; set; }
        public int AudienceCapacity { get; set; }
        
        public int AddressId { get; set; }
    }
}
