using System.Data;
using BehavioralPatterns.Entities;
using BehavioralPatterns.Service;

namespace BehavioralPatterns
{
    public static class Program
    {
        public static void Main()
        {
            try
            {
                EquipmentContext.Instance.InsertData();
                Account account = new()
                {
                    FirstName = "Dmytro",
                    LastName = "Holiaka",
                    Balance = 20000,        // cents
                };

                RentalCard card1 = new(
                    cardId: Guid.NewGuid(),
                    account: account,
                    equipment: "Crane",     // 60$ per hour
                    condition: "Standard",
                    duration: 2
                );

                RentalCard card2 = new(
                    cardId: Guid.NewGuid(),
                    account: account,
                    equipment: "Forklift",  // 30$ per hour
                    condition: "Standard",
                    duration: 1
                );

                Console.WriteLine(account + "\n");

                RentalService service = new();
                service.Rent(card1);
                service.Rent(card2);

                Console.WriteLine();
                Console.WriteLine(account);
                Console.WriteLine();

                service.Terminate(card1.CardId);

                Console.WriteLine();
                Console.WriteLine(account);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"[ArgumentNullException] {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"[ArgumentOutOfRangeException] {ex.Message}");
            }
            catch (DataException ex)
            {
                Console.WriteLine($"[DataException] {ex.Message}");
            }
        }
    }
}