using BehavioralPatterns.Strategies;

namespace BehavioralPatterns.Factory;

public static class PriceStrategyFactory
{
    public static PriceCalculationStrategy CreatePriceStrategy(string? condition) =>
        condition switch
        {
            "Standard" => new StandardPriceStrategy(),
            "Discount" => new DiscountPriceStrategy(),
            "Penalty" => new PenaltyPriceStrategy(),
            _ => throw new ArgumentOutOfRangeException(nameof(condition),
                                                       $"Not expected value of condition: {condition}")
        };
}