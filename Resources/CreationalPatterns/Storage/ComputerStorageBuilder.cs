namespace CreationalPatterns.Storage;

public abstract class ComputerStorageBuilder
{
    public ComputerStorage? ComputerStorage { get; protected set; }

    public abstract void CreateEmptyStorage();
    public abstract void AddMotherboards();
    public abstract void AddProcessors();
    public abstract void AddHardDrives();
    public abstract void AddRams();
}