namespace LINQ_to_Objects.Entities
{
    internal class Jockey
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? MiddleName { get; set; }
        public string? Pseudonym { get; set; }
        public DateTime BirthDate { get; set; }

        public int AddressId { get; set; }
    }
}
