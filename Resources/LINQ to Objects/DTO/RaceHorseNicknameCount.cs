namespace LINQ_to_Objects.DTO
{
    internal class RaceHorseNicknameCount
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int HorseCount { get; set; }

        public override string ToString()
        {
            return $"{Id}.{Number} - {HorseCount} horse(s)";
        }
    }
}
