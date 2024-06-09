namespace StructuralPatterns.Storage;

public abstract class StorageBuilderBase
{
    public abstract void CreateMedicines();
    public abstract void CreatePatients();
    public abstract void CreateDoctors();
    public abstract void CreatePrescriptions();
    public abstract HospitalStorage GetStorage();
}