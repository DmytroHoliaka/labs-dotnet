using CreationalPatterns.Enumerations;

namespace CreationalPatterns.Filters;

public class MotherboardFilter : Filter
{
    public Chipset? Chipset { get; set; }
}