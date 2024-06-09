namespace StructuralPatterns.Storage;

public class StorageConfigurator(StorageBuilderBase storageBuilder)
{
    public HospitalStorage CreateStorage()
    {
        storageBuilder.CreateMedicines();
        storageBuilder.CreatePatients();
        storageBuilder.CreateDoctors();
        storageBuilder.CreatePrescriptions();

        return storageBuilder.GetStorage();
    }
}