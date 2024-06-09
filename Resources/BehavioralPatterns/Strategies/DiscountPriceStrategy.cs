using BehavioralPatterns.Service;

namespace BehavioralPatterns.Strategies;

public class DiscountPriceStrategy : PriceCalculationStrategy
{
    private const double Discount = 0.9;

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
            return (int)Math.Ceiling(equipmentPrice * duration * Discount);
        }

        Console.WriteLine("Specified equipment doesn't exists in context");
        return 0;
    }
}