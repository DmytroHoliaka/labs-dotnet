namespace LINQ_to_Objects.DTO
{
    internal class CaretakerHorseCountInfo
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public int Salary { get; set; }
        public int HorseCount { get; set; }

        public override string ToString()
        {
            return $"{Id}.{FullName} | Salary: {Salary} | Horse count: {HorseCount}";
        }
    }
}
