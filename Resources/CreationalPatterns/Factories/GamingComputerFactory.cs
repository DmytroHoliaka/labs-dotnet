using System.Data;
using CreationalPatterns.Entities;
using CreationalPatterns.Storage;

namespace CreationalPatterns.Factories;

public class GamingComputerFactory(ComputerStorage storage) : ComputerFactory(storage)
{
    public override Motherboard GetMotherboard()
    {
        const string number = "MB001";
        Motherboard motherboard = _storage.Motherboards.FirstOrDefault(m => m.NomenclatureNumber == number)
                                   ?? throw new DataException("Motherboard doesn't exists in database");
        return motherboard;
    }

    public override Processor GetProcessor()
    {
        const string number = "CPU001";
        Processor processor = _storage.Processors.FirstOrDefault(p => p.NomenclatureNumber == number)
                               ?? throw new DataException("Processor doesn't exists in database");
        return processor;
    }

    public override HardDrive GetHardDrive()
    {
        const string number = "HDD004";
        HardDrive hardDrive = _storage.HardDrives.FirstOrDefault(hd => hd.NomenclatureNumber == number)
                               ?? throw new DataException("Hard drive doesn't exists in database");
        return hardDrive;
    }

    public override Ram GetRam()
    {
        const string number = "RAM005";
        Ram ram = _storage.Rams.FirstOrDefault(r => r.NomenclatureNumber == number)
                   ?? throw new DataException("Ram doesn't exists in database");
        return ram;
    }
}