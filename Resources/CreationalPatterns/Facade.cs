using CreationalPatterns.ConfigurationFactories;
using CreationalPatterns.Entities;
using CreationalPatterns.Factories;
using CreationalPatterns.FilterService;
using CreationalPatterns.Storage;

namespace CreationalPatterns;

public static class Facade
{
    public static void Execute(string jsonPath, string basePath)
    {
        ComputerStorageBuilder builder = new CustomComputerBuilder();
        ComputerStorage storage = ComputerStorageDirector.CreatePopulatedStorage(builder);

        IConfigurationFactory configFactory = new ConfigurationFactory
        {
            JsonName = jsonPath,
            BasePath = basePath,
        };

        ComponentFilters filters = FilterConfigurator.GetComponentFilters(configFactory);
        ComputerFactory computerFactory = PackageFactory.GetFactory(storage, filters);
        Computer computer = new(computerFactory);
        Console.WriteLine(computer);
    }
}