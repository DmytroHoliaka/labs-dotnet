using StructuralPatterns.Enumerations;

namespace StructuralPatterns.Entities;

public class Patient
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }

    public override string ToString()
    {
        return $"""
                Name    : {Name},
                Age     : {Age},
                Gender  : {Gender};
                """;
    }
}