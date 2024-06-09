using CreationalPatterns.Entities;
using CreationalPatterns.Storage;

namespace CreationalPatterns.Factories;

public abstract class ComputerFactory(ComputerStorage storage)
{
    protected readonly ComputerStorage _storage = storage;

    public abstract Motherboard GetMotherboard();
    public abstract Processor GetProcessor();
    public abstract HardDrive GetHardDrive();
    public abstract Ram GetRam();
}