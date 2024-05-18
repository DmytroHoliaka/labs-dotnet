using StructuralPatterns.Enumerations;

namespace StructuralPatterns.Entities;

public class Doctor
{
    public string? Name { get; set; }
    public string? Specialization { get; set; }
    public string? Hospital { get; set; }
    public Gender Gender { get; set; }

    public override string ToString()
    {
        return $"""
                Name:            {Name},
                Specialization:  {Specialization},
                Hospital:        {Hospital},
                Gender:          {Gender};
                """;
    }
}