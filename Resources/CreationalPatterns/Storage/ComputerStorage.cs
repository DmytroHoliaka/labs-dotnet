using CreationalPatterns.Entities;

namespace CreationalPatterns.Storage;

public class ComputerStorage
{
    public static ComputerStorage Instance => _lazy.Value;
    private static readonly Lazy<ComputerStorage> _lazy = new(() => new ComputerStorage());
    
    private ComputerStorage()
    {
    }

    public List<Motherboard> Motherboards { get; } = [];
    public List<Processor> Processors { get; } = [];
    public List<HardDrive> HardDrives { get; } = [];
    public List<Ram> Rams { get; } = [];
}