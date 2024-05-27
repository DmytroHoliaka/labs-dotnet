using BehavioralPatterns.Service;

namespace BehavioralPatterns.Strategies;

public class PenaltyPriceStrategy: PriceCalculationStrategy
{
    private const double Penalty = 0.9;

    public override int CalculatePrice(string? equipmentName, int duration)
    {
        ArgumentNullException.ThrowIfNull(equipmentName, nameof(equipmentName));
        ArgumentNullException.ThrowIfNull(duration, nameof(duration));

        if (duration <= 0)
        {
            Console.WriteLine("Duration (hours) must be positive number.");
            return 0;
        }

        Dictionary<string, int> prices = EquipmentContext.Instance.BasePrices;

        if (prices.TryGetValue(equipmentName, out int equipmentPrice))
        {
            return (int)Math.Ceiling(equipmentPrice * duration * Penalty);
        }

        Console.WriteLine("Specified equipment doesn't exists in context");
        return 0;
    }
}