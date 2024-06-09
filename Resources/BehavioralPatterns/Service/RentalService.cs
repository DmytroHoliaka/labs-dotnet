using BehavioralPatterns.Commands;
using BehavioralPatterns.Entities;

namespace BehavioralPatterns.Service;

public class RentalService
{
    private readonly List<RentalCommand> _rentals = [];

    public void Rent(RentalCard? rentalCard)
    {
        ArgumentNullException.ThrowIfNull(rentalCard, nameof(rentalCard));

        RentalEquipmentCommand command = new(rentalCard: rentalCard);
        command.Execute();
        _rentals.Add(command);
    }

    public void Terminate(Guid cardId)
    {
        RentalCommand? command = _rentals.FirstOrDefault(c => c.RentalCard.CardId == cardId);

        if (command is null)
        {
            Console.WriteLine("The specified rental card is not in the list.");
            return;
        }

        command.Undo();
        _rentals.Remove(command);
    }
}