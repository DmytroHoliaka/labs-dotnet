using StructuralPatterns.Entities;
using StructuralPatterns.Prescriptions;

namespace StructuralPatterns.Storage;

public class HospitalStorage
{
    public static HospitalStorage Instance => _instance ??= new HospitalStorage();
    private static HospitalStorage? _instance;

    public readonly List<Medicine> Medicines = [];
    public readonly List<Patient> Patients = [];
    public readonly List<Doctor> Doctors = [];
    public readonly List<PrescriptionBase> Prescriptions = [];

    private HospitalStorage()
    {
    }
}