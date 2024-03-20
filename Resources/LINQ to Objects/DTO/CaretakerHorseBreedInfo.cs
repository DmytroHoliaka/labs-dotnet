namespace LINQ_to_Objects.DTO
{
    internal class CaretakerHorseBreedInfo
    {
        public int Id {get;set;}
        public string? FullName {get;set;}
        public string? HorseBreed {get;set;}

        public override string? ToString()
        {
            return $"{Id}.{FullName} takes care of a {HorseBreed} horse ";
        }
    }
}
