using CreationalPatterns.Enumerations;
using CreationalPatterns.Factories;

namespace CreationalPatterns.Entities;

public class Computer(ComputerFactory factory)
{
    private readonly Motherboard? _motherboard = factory.GetMotherboard();
    private readonly Processor? _processor = factory.GetProcessor();
    private readonly HardDrive? _hardDrive = factory.GetHardDrive();
    private readonly Ram? _ram = factory.GetRam();

    public override string ToString()
    {
        return $"""
                Motherboard 
                    Name:     {_motherboard?.Name ?? "<null>"}
                    Chipset:  {_motherboard?.Chipset ?? Chipset.Unknown}
                    
                Processor
                    Name:        {_processor?.Name ?? "<null>"}
                    Core count:  {_processor?.CoreCount ?? -1}
                    
                HardDrive
                    Name:                 {_hardDrive?.Name ?? "<null>"} 
                    Hard drive capacity:  {_hardDrive?.Capacity ?? -1}
                    
                OperativeMemory
                    Name:          {_ram?.Name ?? "<null>"} 
                    Ram capacity:  {_ram?.Capacity ?? -1}
                """;
    }
}