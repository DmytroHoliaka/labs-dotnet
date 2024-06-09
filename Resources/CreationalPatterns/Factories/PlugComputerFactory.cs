using CreationalPatterns.Entities;
using CreationalPatterns.Enumerations;
using CreationalPatterns.Storage;

namespace CreationalPatterns.Factories;

public class PlugComputerFactory(ComputerStorage storage) : ComputerFactory(storage)
{
    public override Motherboard GetMotherboard()
    {
        return new Motherboard
        {
            Name = "<no combination found>",
            Chipset = Chipset.Unknown,
        };
    }

    public override Processor GetProcessor()
    {
        return new Processor
        {
            Name = "<no combination found>"
        };
    }

    public override HardDrive GetHardDrive()
    {
        return new HardDrive
        {
            Name = "<no combination found>"
        };
    }

    public override Ram GetRam()
    {
        return new Ram
        {
            Name = "<no combination found>"
        };
    }
}