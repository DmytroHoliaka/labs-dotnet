using StructuralPatterns.Prescriptions;
using StructuralPatterns.Prescriptions.Prescriptions;
using StructuralPatterns.Storage;

namespace StructuralPatterns;

public class HospitalFacade
{
    private readonly HospitalStorage _storage;

    public HospitalFacade()
    {
        DefaultStorageBuilder storageBuilder = new();
        StorageConfigurator storageConfigurator = new(storageBuilder);
        _storage = storageConfigurator.CreateStorage();
    }

    public PrescriptionBase GetFirstPrescriptionFromStorage()
    {
        PrescriptionBase prescriptionBase = _storage.Prescriptions.First();
        return prescriptionBase;
    }

    public static PrescriptionBase ExtendExpiryDate(PrescriptionBase prescription, int additionalDays)
    {
        PrescriptionBase decorator = new ExpiryDateExtensionDecorator(
            prescriptionBase: prescription,
            additionalDays: additionalDays);

        return decorator;
    }
}