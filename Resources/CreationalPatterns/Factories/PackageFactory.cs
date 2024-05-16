using CreationalPatterns.Enumerations;
using CreationalPatterns.FilterService;
using CreationalPatterns.Storage;

namespace CreationalPatterns.Factories;

public static class PackageFactory
{
    public static ComputerFactory GetFactory(ComputerStorage? storage, ComponentFilters? filterConfigurator)
    {
        ArgumentNullException.ThrowIfNull(filterConfigurator, nameof(filterConfigurator));
        ArgumentNullException.ThrowIfNull(storage, nameof(storage));

        IEnumerable<Chipset> officeChipsets = [Chipset.IntelB660, Chipset.IntelH670, Chipset.AmdX470];
        IEnumerable<int> officeCoreCount = [2, 4, 6];
        IEnumerable<int> officeDriveCapacity = [256];
        IEnumerable<int> officeRamCapacity = [4];

        IEnumerable<Chipset> eduChipsets = [Chipset.IntelB660, Chipset.IntelH670, Chipset.AmdX470];
        IEnumerable<int> eduCoreCount = [4, 6];
        IEnumerable<int> eduDriveCapacity = [512];
        IEnumerable<int> eduRamCapacity = [8];

        IEnumerable<Chipset> gamingChipsets = [Chipset.IntelZ690, Chipset.AmdX570];
        IEnumerable<int> gamingCoreCount = [8];
        IEnumerable<int> gamingDriveCapacity = [1024];
        IEnumerable<int> gamingRamCapacity = [16];

        IEnumerable<Chipset> proChipsets = [Chipset.IntelZ690, Chipset.AmdX570];
        IEnumerable<int> proCoreCount = [12];
        IEnumerable<int> proDriveCapacity = [2048];
        IEnumerable<int> proRamCapacity = [32];

        if ((filterConfigurator.MotherboardFilter?.Chipset is null ||
             officeChipsets.Contains(filterConfigurator.MotherboardFilter.Chipset.Value)) &&
            (filterConfigurator.ProcessorFilter?.CoreCount is null ||
             officeCoreCount.Contains(filterConfigurator.ProcessorFilter.CoreCount.Value)) &&
            (filterConfigurator.HardDriveFilter?.Capacity is null ||
             officeDriveCapacity.Contains(filterConfigurator.HardDriveFilter.Capacity.Value)) &&
            (filterConfigurator.RamFilter?.Capacity is null ||
             officeRamCapacity.Contains(filterConfigurator.RamFilter.Capacity.Value)))
        {
            return new OfficeComputerFactory(storage);
        }

        if ((filterConfigurator.MotherboardFilter?.Chipset is null ||
             eduChipsets.Contains(filterConfigurator.MotherboardFilter.Chipset.Value)) &&
            (filterConfigurator.ProcessorFilter?.CoreCount is null ||
             eduCoreCount.Contains(filterConfigurator.ProcessorFilter.CoreCount.Value)) &&
            (filterConfigurator.HardDriveFilter?.Capacity is null ||
             eduDriveCapacity.Contains(filterConfigurator.HardDriveFilter.Capacity.Value)) &&
            (filterConfigurator.RamFilter?.Capacity is null ||
             eduRamCapacity.Contains(filterConfigurator.RamFilter.Capacity.Value)))
        {
            return new EducationalComputerFactory(storage);
        }

        if ((filterConfigurator.MotherboardFilter?.Chipset is null ||
             gamingChipsets.Contains(filterConfigurator.MotherboardFilter.Chipset.Value)) &&
            (filterConfigurator.ProcessorFilter?.CoreCount is null ||
             gamingCoreCount.Contains(filterConfigurator.ProcessorFilter.CoreCount.Value)) &&
            (filterConfigurator.HardDriveFilter?.Capacity is null ||
             gamingDriveCapacity.Contains(filterConfigurator.HardDriveFilter.Capacity.Value)) &&
            (filterConfigurator.RamFilter?.Capacity is null ||
             gamingRamCapacity.Contains(filterConfigurator.RamFilter.Capacity.Value)))
        {
            return new GamingComputerFactory(storage);
        }

        if ((filterConfigurator.MotherboardFilter?.Chipset is null ||
             proChipsets.Contains(filterConfigurator.MotherboardFilter.Chipset.Value)) &&
            (filterConfigurator.ProcessorFilter?.CoreCount is null ||
             proCoreCount.Contains(filterConfigurator.ProcessorFilter.CoreCount.Value)) &&
            (filterConfigurator.HardDriveFilter?.Capacity is null ||
             proDriveCapacity.Contains(filterConfigurator.HardDriveFilter.Capacity.Value)) &&
            (filterConfigurator.RamFilter?.Capacity is null ||
             proRamCapacity.Contains(filterConfigurator.RamFilter.Capacity.Value)))
        {
            return new ProfessionalComputerFactory(storage);
        }

        return new PlugComputerFactory(storage);
    }
}