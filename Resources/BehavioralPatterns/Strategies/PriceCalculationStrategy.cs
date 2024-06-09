namespace BehavioralPatterns.Strategies;

public abstract class PriceCalculationStrategy
{
    public abstract int CalculatePrice(string? equipmentName, int duration);
}