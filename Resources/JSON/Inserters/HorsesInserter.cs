using Json.Entities;

namespace Json.Inserters
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
            };

            Horse horse2 = new()
            {
                Id = 2,
                Breed = "Arabian",
                Nickname = "Lightning",
                Age = 4,
            };

            Horse horse3 = new()
            {
                Id = 3,
                Breed = "Quarter Horse",
                Nickname = "Dash",
                Age = 5,
            };

            Horse horse4 = new()
            {
                Id = 4,
                Breed = "Arabian",
                Nickname = "Spot",
                Age = 2,
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
