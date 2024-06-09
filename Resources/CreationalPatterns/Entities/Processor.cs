using CreationalPatterns.Enumerations;

namespace CreationalPatterns.Entities;

public class Processor : Component
{
    public int CoreCount { get; set; }
    public double ClockFrequency { get; set; }
 
    public ConnectorType ConnectorType { get; set; }

    public override Component Clone()
    {
        return new Processor
        {
            NomenclatureNumber = NomenclatureNumber,
            Name = Name,
            Price = Price,
            CoreCount = CoreCount,
            ClockFrequency = ClockFrequency,
            ConnectorType = ConnectorType
        };
    }
}