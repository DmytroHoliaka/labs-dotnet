using LINQ_to_Objects.Inserters;
using LINQ_to_Objects.Service;

namespace LINQ_to_Objects.Execution
{
    internal class Facade
    {
        public static void Execute()
        {
            DataContext data = new();

            AddressesInserter.InsertAddresses(data.Addresses);
            CaretakersInserter.InsertCaretakers(data.Caretakers);
            DetailResultsInserter.InsertDetailResults(data.DetailResults);
            HorsesInserter.InsertHorses(data.Horses);
            JockeysInserter.InsertJockeys(data.Jockeys);
            ParticipantsInserter.InsertParticipants(data.Participants);
            RacesInserter.InsertRaces(data.Races);
            StadiumsInserter.InsertStadiums(data.Stadiums);

            var addresses = data.Addresses.Select(a => new
            {
                a.Id,
                a.Country,
                a.Area,
                a.District,
                a.PostalCode,
                a.Street,
                a.BuildingNumber,
            });

            foreach (var address in addresses)
            {
                Console.WriteLine(address);
            }
        }
    }
}
