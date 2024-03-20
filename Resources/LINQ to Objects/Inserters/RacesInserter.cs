using LINQ_to_Objects.Entities;

namespace LINQ_to_Objects.Inserters
{
    internal class RacesInserter
    {
        public static void InsertRaces(List<Race>? races)
        {
            if (races is null)
            {
                throw new ArgumentNullException(nameof(races), "Input list of races cannot be null");
            }

            Race race1 = new()
            {
                Id = 1,
                Number = 1001,
                StartDate = new DateTime(2024, 4, 10, 14, 30, 0),
                StadiumId = 1
            };

            Race race2 = new()
            {
                Id = 2,
                Number = 1002,
                StartDate = new DateTime(2024, 4, 11, 15, 00, 0),
                StadiumId = 2
            };

            races.AddRange(new List<Race>()
            {
                race1,
                race2,
            });
        }
    }
}
