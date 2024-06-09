namespace CreationalPatterns.Storage;

public class ComputerStorageDirector
{
    public static ComputerStorage CreatePopulatedStorage(ComputerStorageBuilder builder)
    {
        builder.CreateEmptyStorage();
        builder.AddMotherboards();
        builder.AddProcessors();
        builder.AddHardDrives();
        builder.AddRams();

        return builder.ComputerStorage!;
    }
}