namespace StructuralPatterns.Entities;

public class Medicine
{
    public string? Name { get; set; }
    public string? Manufacturer { get; set; }
    public double Dosage { get; set; }

    public override string ToString()
    {
        return $"""
                Name            : {Name},
                Manufacturer    : {Manufacturer},
                Dosage          : {Dosage};
                """;
    }
}