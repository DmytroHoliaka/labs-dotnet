namespace LINQ_to_Objects.DTO
{
    internal class AddressShortInfo
    {
        public int Id { get; set; }
        public string? Country { get; set; }
        public int BuildingNumber { get; set; }

        public override string ToString()
        {
            return $"{Id}.{Country} (Building number: {BuildingNumber})";
        }
    }
}
