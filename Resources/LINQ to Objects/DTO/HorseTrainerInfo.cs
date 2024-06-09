using LINQ_to_Objects.Entities;

namespace LINQ_to_Objects.DTO
{
    internal class HorseTrainerInfo
    {
        public int HorseId {get;set;}
        public string? HorseNickname {get;set;}
        public string? CaretakerType {get;set;}

        public override string ToString()
        {
            return $"{HorseId}.{HorseNickname} has {CaretakerType}";
        }
    }
}
