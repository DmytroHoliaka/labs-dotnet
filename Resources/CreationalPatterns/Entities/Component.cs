namespace CreationalPatterns.Entities;

public abstract class Component
{
    public string? NomenclatureNumber { get; set; }
    public string? Name { get; set; }
    public int Price { get; set; }

    public abstract Component Clone();
}