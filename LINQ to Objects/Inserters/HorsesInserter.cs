using LINQ_to_Objects.Entities;

namespace LINQ_to_Objects.Inserters
{
    internal class HorsesInserter
    {
        public static void InsertHorses(List<Horse>? horses)
        {
            if (horses is null)
            {
                throw new ArgumentNullException(nameof(horses), "Input list of horses cannot be null");
            }

            Horse horse1 = new()
            {
                Id = 1,
                Breed = "Thoroughbred",
                Nickname = "Lightning",
                Age = 3,
                CaretakerIds = new List<int> { 1, 2 }
            };

            Horse horse2 = new()
            {
                Id = 2,
                Breed = "Arabian",
                Nickname = "Blaze",
                Age = 4,
                CaretakerIds = new List<int> { 2 }
            };

            Horse horse3 = new()
            {
                Id = 3,
                Breed = "Quarter Horse",
                Nickname = "Dash",
                Age = 5,
                CaretakerIds = new List<int> { 1 }
            };

            Horse horse4 = new()
            {
                Id = 4,
                Breed = "Appaloosa",
                Nickname = "Spot",
                Age = 2,
                CaretakerIds = new List<int> { 3 }
            };


            horses.AddRange(new List<Horse>()
            {
                horse1,
                horse2,
                horse3,
                horse4,
            });
        }
    }
}
