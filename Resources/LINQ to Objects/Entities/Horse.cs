namespace LINQ_to_Objects.Entities
{
    internal class Horse
    {
        public int Id { get; set; }
        public string? Breed { get; set; }
        public string? Nickname { get; set; }
        public int Age { get; set; }

        public IEnumerable<int>? CaretakerIds { get; set; }
    }
}
