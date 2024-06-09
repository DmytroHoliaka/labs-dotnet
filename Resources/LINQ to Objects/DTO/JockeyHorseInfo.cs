namespace LINQ_to_Objects.DTO
{
    internal class JockeyHorseInfo
    {
        public string? FullName {get;set;}
        public string? HorseNickname {get;set;}   

        public override string ToString()
        {
            return $"Jockey: {FullName}  -  Horse: {HorseNickname}";
        }
    }
}
