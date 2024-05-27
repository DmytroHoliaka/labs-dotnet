using BehavioralPatterns.Entities;
using BehavioralPatterns.Strategies;

namespace BehavioralPatterns.Commands;

public abstract class RentalCommand
{
    public readonly RentalCard RentalCard;
    protected PriceCalculationStrategy? Strategy;

    protected RentalCommand(RentalCard? rentalCard)
    {
        ArgumentNullException.ThrowIfNull(rentalCard);
        RentalCard = rentalCard;
    }

    public abstract void Execute();
    public abstract void Undo();
}