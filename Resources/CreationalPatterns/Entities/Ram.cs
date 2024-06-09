using CreationalPatterns.Enumerations;

namespace CreationalPatterns.Entities;

public class Ram : Component
{
    public int Capacity { get; set; }
    public int Frequency { get; set; }
    public int StripCount { get; set; }

    public RamType Type { get; set; }

    public override Component Clone()
    {
        return new Ram
        {
            NomenclatureNumber = NomenclatureNumber,
            Name = Name,
            Price = Price,
            Capacity = Capacity,
            Frequency = Frequency,
            StripCount = StripCount,
            Type = Type
        };
    }
}