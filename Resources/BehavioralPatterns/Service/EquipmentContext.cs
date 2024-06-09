namespace BehavioralPatterns.Service;

public class EquipmentContext
{
    public static EquipmentContext Instance => _lazy.Value;
    private static readonly Lazy<EquipmentContext> _lazy = new(() => new EquipmentContext()); 
    
    public readonly Dictionary<string, int> BasePrices = [];

    private EquipmentContext()
    {
    }

    public void InsertData()
    {
        BasePrices.Add("Excavator", 5000);
        BasePrices.Add("Bulldozer", 4500);
        BasePrices.Add("Crane", 6000);
        BasePrices.Add("Forklift", 3000);
        BasePrices.Add("Dump Truck", 5500);
        BasePrices.Add("Concrete Mixer", 4000);
        BasePrices.Add("Generator", 2500);
        BasePrices.Add("Scissor Lift", 3500);
        BasePrices.Add("Backhoe Loader", 4800);
        BasePrices.Add("Compactor", 3700);
    }
}