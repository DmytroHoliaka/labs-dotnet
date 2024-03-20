using LINQ_to_Objects.DTO;
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

            Printer.PrintMenu();
            int firstItem = 1;
            int lastItem = 20;
            int currentItem;

            do
            {
                Console.Write($"\nEnter your choice [{firstItem}; {lastItem}]: ");
                string? inputLine = Console.ReadLine();

                if (inputLine.IsValid() && (currentItem = Convert.ToInt32(inputLine)).IsInRange(firstItem, lastItem))
                {
                    QueryExecutor.Execute(data, currentItem);
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }

                Console.Write("\nPress <Enter> to continue ...");
            }
            while (Console.ReadKey().Key == ConsoleKey.Enter);

            Console.WriteLine("\nProgram ends.");
        }
    }
}
