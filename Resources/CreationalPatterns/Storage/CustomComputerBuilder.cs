using CreationalPatterns.Entities;
using CreationalPatterns.Enumerations;

namespace CreationalPatterns.Storage;

public class CustomComputerBuilder : ComputerStorageBuilder
{
    public override void CreateEmptyStorage()
    {
        ComputerStorage = ComputerStorage.Instance;
    }

    public override void AddMotherboards()
    {
        ArgumentNullException.ThrowIfNull(ComputerStorage, nameof(ComputerStorage));

        Motherboard motherboard1 = new()
        {
            NomenclatureNumber = "MB001",
            Name = "ASUS ROG Strix Z690-E Gaming WIFI",
            Price = 38900,
            ProcessorCount = 1,
            BusFrequency = 3200,
            SocketType = SocketType.Lga1200,
            Chipset = Chipset.IntelZ690,
            RamType = RamType.LpDdr5
        };

        Motherboard motherboard2 = new()
        {
            NomenclatureNumber = "MB002",
            Name = "GIGABYTE X470 AORUS Elite",
            Price = 19900,
            ProcessorCount = 1,
            BusFrequency = 3600,
            SocketType = SocketType.Am4,
            Chipset = Chipset.AmdX470,
            RamType = RamType.LpDdr4
        };

        Motherboard motherboard3 = new()
        {
            NomenclatureNumber = "MB003",
            Name = "MSI B660M PRO-VDH WIFI",
            Price = 10900,
            ProcessorCount = 1,
            BusFrequency = 3000,
            SocketType = SocketType.Lga1200,
            Chipset = Chipset.IntelB660,
            RamType = RamType.Ddr4
        };

        Motherboard motherboard4 = new()
        {
            NomenclatureNumber = "MB004",
            Name = "ASRock X570 Taichi Ultimate",
            Price = 26900,
            ProcessorCount = 1,
            BusFrequency = 3400,
            SocketType = SocketType.Am4,
            Chipset = Chipset.AmdX570,
            RamType = RamType.Ddr4
        };

        Motherboard motherboard5 = new()
        {
            NomenclatureNumber = "MB005",
            Name = "ASUS ROG Strix TRX40-E Gaming",
            Price = 54900,
            ProcessorCount = 1,
            BusFrequency = 3600,
            SocketType = SocketType.Tr4,
            Chipset = Chipset.IntelH670,
            RamType = RamType.Ddr3
        };

        Motherboard motherboard6 = new()
        {
            NomenclatureNumber = "MB006",
            Name = "GIGABYTE Z690M Gaming X",
            Price = 15900,
            ProcessorCount = 1,
            BusFrequency = 3200,
            SocketType = SocketType.Lga1200,
            Chipset = Chipset.IntelZ690,
            RamType = RamType.Ddr5
        };

        ComputerStorage.Motherboards.AddRange([
            motherboard1,
            motherboard2,
            motherboard3,
            motherboard4,
            motherboard5,
            motherboard6
        ]);
    }

    public override void AddProcessors()
    {
        ArgumentNullException.ThrowIfNull(ComputerStorage, nameof(ComputerStorage));

        Processor processor1 = new()
        {
            NomenclatureNumber = "CPU001",
            Name = "Intel Core i9-11900K",
            Price = 53900,
            CoreCount = 8,
            ClockFrequency = 3.5,
            ConnectorType = ConnectorType.Lga
        };

        Processor processor2 = new()
        {
            NomenclatureNumber = "CPU002",
            Name = "AMD Ryzen 9 5900X",
            Price = 54900,
            CoreCount = 12,
            ClockFrequency = 3.7,
            ConnectorType = ConnectorType.Pga
        };

        Processor processor3 = new()
        {
            NomenclatureNumber = "CPU003",
            Name = "Intel Core i5-8700K",
            Price = 26900,
            CoreCount = 6,
            ClockFrequency = 3.7,
            ConnectorType = ConnectorType.Lga
        };

        Processor processor4 = new()
        {
            NomenclatureNumber = "CPU004",
            Name = "AMD Ryzen 7 5800X",
            Price = 39900,
            CoreCount = 12,
            ClockFrequency = 3.8,
            ConnectorType = ConnectorType.Pga
        };

        Processor processor5 = new()
        {
            NomenclatureNumber = "CPU005",
            Name = "Intel Core i3-12100",
            Price = 12900,
            CoreCount = 4,
            ClockFrequency = 3.2,
            ConnectorType = ConnectorType.Lga
        };

        Processor processor6 = new()
        {
            NomenclatureNumber = "CPU006",
            Name = "AMD Ryzen 5 5600X",
            Price = 29900,
            CoreCount = 6,
            ClockFrequency = 3.7,
            ConnectorType = ConnectorType.Pga
        };


        ComputerStorage.Processors.AddRange([
            processor1,
            processor2,
            processor3,
            processor4,
            processor5,
            processor6
        ]);
    }

    public override void AddHardDrives()
    {
        ArgumentNullException.ThrowIfNull(ComputerStorage, nameof(ComputerStorage));

        HardDrive hardDrive1 = new()
        {
            NomenclatureNumber = "HDD001",
            Name = "Seagate Barracuda 2TB",
            Price = 6900,
            Capacity = 2048,
            Speed = 7200,
            ConnectionInterface = ConnectionInterface.Sata
        };

        HardDrive hardDrive2 = new()
        {
            NomenclatureNumber = "HDD002",
            Name = "Western Digital Blue 512TB",
            Price = 4900,
            Capacity = 512,
            Speed = 7200,
            ConnectionInterface = ConnectionInterface.Sata
        };

        HardDrive hardDrive3 = new()
        {
            NomenclatureNumber = "HDD003",
            Name = "Samsung 970 EVO Plus 500GB",
            Price = 5400,
            Capacity = 512,
            Speed = 3500,
            ConnectionInterface = ConnectionInterface.Nvme
        };

        HardDrive hardDrive4 = new()
        {
            NomenclatureNumber = "HDD004",
            Name = "Corsair MP600 1TB",
            Price = 13900,
            Capacity = 1024,
            Speed = 4950,
            ConnectionInterface = ConnectionInterface.Pcie
        };

        HardDrive hardDrive5 = new()
        {
            NomenclatureNumber = "HDD005",
            Name = "Crucial MX500 256TB",
            Price = 6400,
            Capacity = 256,
            Speed = 560,
            ConnectionInterface = ConnectionInterface.Sata
        };

        HardDrive hardDrive6 = new()
        {
            NomenclatureNumber = "HDD006",
            Name = "Sabrent Rocket Q 2TB",
            Price = 14900,
            Capacity = 2048,
            Speed = 3200,
            ConnectionInterface = ConnectionInterface.Nvme
        };

        ComputerStorage.HardDrives.AddRange([
            hardDrive1,
            hardDrive2,
            hardDrive3,
            hardDrive4,
            hardDrive5,
            hardDrive6
        ]);
    }

    public override void AddRams()
    {
        ArgumentNullException.ThrowIfNull(ComputerStorage, nameof(ComputerStorage));

        Ram ram1 = new()
        {
            NomenclatureNumber = "RAM001",
            Name = "Corsair Vengeance LPX 16GB",
            Price = 6900,
            Capacity = 16,
            Frequency = 3200,
            StripCount = 2,
            Type = RamType.Ddr4
        };

        Ram ram2 = new()
        {
            NomenclatureNumber = "RAM002",
            Name = "Crucial Ballistix 4GB",
            Price = 10500,
            Capacity = 4,
            Frequency = 3600,
            StripCount = 1,
            Type = RamType.Ddr4
        };

        Ram ram3 = new()
        {
            NomenclatureNumber = "RAM003",
            Name = "G.Skill Ripjaws V 8GB",
            Price = 4000,
            Capacity = 8,
            Frequency = 3000,
            StripCount = 1,
            Type = RamType.Ddr4
        };

        Ram ram4 = new()
        {
            NomenclatureNumber = "RAM004",
            Name = "Kingston HyperX Fury 16GB",
            Price = 6200,
            Capacity = 16,
            Frequency = 2666,
            StripCount = 2,
            Type = RamType.Ddr4
        };

        Ram ram5 = new()
        {
            NomenclatureNumber = "RAM005",
            Name = "Corsair Vengeance LPX 16GB",
            Price = 12500,
            Capacity = 16,
            Frequency = 3200,
            StripCount = 2,
            Type = RamType.Ddr4
        };

        Ram ram6 = new()
        {
            NomenclatureNumber = "RAM006",
            Name = "Crucial Ballistix RGB 32GB",
            Price = 8400,
            Capacity = 32,
            Frequency = 3200,
            StripCount = 2,
            Type = RamType.Ddr4
        };

        ComputerStorage.Rams.AddRange([
            ram1,
            ram2,
            ram3,
            ram4,
            ram5,
            ram6,
        ]);
    }
}