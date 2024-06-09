using StructuralPatterns.Entities;

namespace StructuralPatterns.Prescriptions;

public abstract class PrescriptionBase
{
    public List<Medicine>? Medicines { get; set; }
    public Doctor? Doctor { get; set; }
    public Patient? Patient { get; set; }
    public DateTime ExpiryDate { get; set; }

    public abstract void PrintDetails(Action<string>? source);
}