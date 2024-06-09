using CreationalPatterns.Enumerations;

namespace CreationalPatterns.Entities;

public class HardDrive : Component
{
    public int Capacity { get; set; }
    public int Speed { get; set; }
    
    public ConnectionInterface ConnectionInterface { get; set; }

    public override Component Clone()
    {
        return new HardDrive()
        {
            NomenclatureNumber = NomenclatureNumber,
            Name = Name,
            Price = Price,
            Capacity = Capacity,
            Speed = Speed,
            ConnectionInterface = ConnectionInterface,
        };
    }
}