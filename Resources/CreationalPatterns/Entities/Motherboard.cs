using CreationalPatterns.Enumerations;

namespace CreationalPatterns.Entities;

public class Motherboard : Component
{
    public int ProcessorCount { get; set; }
    public int BusFrequency { get; set; }
 
    public SocketType SocketType { get; set; }
    public Chipset Chipset { get; set; }
    public RamType RamType { get; set; }

    public override Component Clone()
    {
        return new Motherboard
        {
            NomenclatureNumber = NomenclatureNumber,
            Name = Name,
            Price = Price,
            ProcessorCount = ProcessorCount,
            BusFrequency = BusFrequency,
            SocketType = SocketType,
            Chipset = Chipset,
            RamType = RamType
        };
    }
}