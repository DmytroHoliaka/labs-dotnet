namespace LINQ_to_XML.DTO
{
    internal class CaretakerBreed
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Breed { get; set; }
        public int HorseCount { get; set; }

        public override string ToString()
        {
            return $"#{Id} | Caretaker: {FullName} | Breed: {Breed} | Horse count: {HorseCount}";
        }
    }
}
