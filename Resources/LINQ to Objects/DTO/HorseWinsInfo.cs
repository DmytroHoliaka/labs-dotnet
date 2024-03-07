namespace LINQ_to_Objects.DTO
{
    internal class HorseWinsInfo
    {
        public int Id { get; set; }
        public string? Nickname { get; set; }
        public int WinningCount { get; set; }

        public override string ToString()
        {
            return $"{Id}.{Nickname} - {WinningCount} win(s)";
        }
    }
}
