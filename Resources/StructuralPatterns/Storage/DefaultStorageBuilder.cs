using System.Data;
using StructuralPatterns.Entities;
using StructuralPatterns.Enumerations;
using StructuralPatterns.Prescriptions;

namespace StructuralPatterns.Storage;

public class DefaultStorageBuilder : StorageBuilderBase
{
    public override void CreateMedicines()
    {
        List<Medicine> medicines =
        [
            new Medicine
            {
                Name = "Paracetamol",
                Manufacturer = "Pharma Inc.",
                Dosage = 500
            },

            new Medicine
            {
                Name = "Ibuprofen",
                Manufacturer = "HealthCare Co.",
                Dosage = 200
            },

            new Medicine
            {
                Name = "Amoxicillin",
                Manufacturer = "BioPharm Ltd.",
                Dosage = 250
            },

            new Medicine
            {
                Name = "Ciprofloxacin",
                Manufacturer = "MedLife",
                Dosage = 500
            },

            new Medicine
            {
                Name = "Aspirin",
                Manufacturer = "Pharma Inc.",
                Dosage = 100
            }
        ];

        HospitalStorage.Instance.Medicines.AddRange(medicines);
    }

    public override void CreatePatients()
    {
        List<Patient> patients =
        [
            new Patient
            {
                Name = "John Doe",
                Age = 30,
                Gender = Gender.Male
            },

            new Patient
            {
                Name = "Jane Smith",
                Age = 25,
                Gender = Gender.Female
            },

            new Patient
            {
                Name = "Bob Brown",
                Age = 40,
                Gender = Gender.Male
            },

            new Patient
            {
                Name = "Alice Johnson",
                Age = 35,
                Gender = Gender.Female
            },

            new Patient
            {
                Name = "Eve Davis",
                Age = 28,
                Gender = Gender.Female
            }
        ];

        HospitalStorage.Instance.Patients.AddRange(patients);
    }

    public override void CreateDoctors()
    {
        List<Doctor> doctors =
        [
            new Doctor
            {
                Name = "Dr. John Watson",
                Specialization = "Cardiology",
                Hospital = "City Hospital",
                Gender = Gender.Male
            },

            new Doctor
            {
                Name = "Dr. Emily Clark",
                Specialization = "Neurology",
                Hospital = "City Hospital",
                Gender = Gender.Female
            },

            new Doctor
            {
                Name = "Dr. Michael Adams",
                Specialization = "Orthopedics",
                Hospital = "General Hospital",
                Gender = Gender.Male
            },

            new Doctor
            {
                Name = "Dr. Sarah Wilson",
                Specialization = "Pediatrics",
                Hospital = "Children's Hospital",
                Gender = Gender.Female
            },

            new Doctor
            {
                Name = "Dr. Robert Green",
                Specialization = "Dermatology",
                Hospital = "Skin Care Clinic",
                Gender = Gender.Male
            }
        ];

        HospitalStorage.Instance.Doctors.AddRange(doctors);
    }

    public override void CreatePrescriptions()
    {
        HospitalStorage storage = HospitalStorage.Instance;

        if (IsSimpleDataInserted() == false)
        {
            throw new DataException("Simple data was not completely inserted");
        }

        List<Prescription> prescriptions =
        [
            new Prescription
            {
                Medicines =
                [
                    storage.Medicines[0],
                    storage.Medicines[1]
                ],
                Doctor = storage.Doctors[0],
                Patient = storage.Patients[0],
                ExpiryDate = DateTime.Now.AddMonths(1)
            },

            new Prescription
            {
                Medicines =
                [
                    storage.Medicines[2],
                    storage.Medicines[3]
                ],
                Doctor = storage.Doctors[1],
                Patient = storage.Patients[1],
                ExpiryDate = DateTime.Now.AddMonths(1)
            },

            new Prescription
            {
                Medicines =
                [
                    storage.Medicines[1],
                    storage.Medicines[4]
                ],
                Doctor = storage.Doctors[2],
                Patient = storage.Patients[2],
                ExpiryDate = DateTime.Now.AddMonths(2)
            },

            new Prescription
            {
                Medicines =
                [
                    storage.Medicines[0],
                    storage.Medicines[3]
                ],
                Doctor = storage.Doctors[3],
                Patient = storage.Patients[3],
                ExpiryDate = DateTime.Now.AddMonths(3)
            },

            new Prescription
            {
                Medicines =
                [
                    storage.Medicines[4],
                    storage.Medicines[2]
                ],
                Doctor = storage.Doctors[4],
                Patient = storage.Patients[4],
                ExpiryDate = DateTime.Now.AddMonths(2)
            }
        ];

        storage.Prescriptions.AddRange(prescriptions);
    }

    public override HospitalStorage GetStorage()
    {
        return HospitalStorage.Instance;
    }

    private static bool IsSimpleDataInserted()
    {
        return HospitalStorage.Instance.Medicines.Count > 0 &&
               HospitalStorage.Instance.Patients.Count > 0 &&
               HospitalStorage.Instance.Doctors.Count > 0;
    }
}