using CreationalPatterns.Filters;

namespace CreationalPatterns.FilterService;

public class ComponentFilters
{
    public MotherboardFilter? MotherboardFilter { get; set; }
    public ProcessorFilter? ProcessorFilter { get; set; }
    public HardDriveFilter? HardDriveFilter { get; set; }
    public RamFilter? RamFilter { get; set; }
}