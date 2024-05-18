namespace StructuralPatterns.Prescriptions;

public class Prescription : PrescriptionBase
{
    public override void PrintDetails(Action<string>? source)
    {
        ArgumentNullException.ThrowIfNull(source, nameof(source));

        if (Medicines is not null)
        {
            source.Invoke("-------------- Medicines --------------");
            Medicines.ForEach(m => source.Invoke(m.ToString()));
            source.Invoke(string.Empty);
        }

        if (Doctor is not null)
        {
            source.Invoke("-------------- Doctor --------------");
            source.Invoke(Doctor.ToString());
            source.Invoke(string.Empty);
        }

        if (Patient is not null)
        {
            source.Invoke("-------------- Patient --------------");
            source.Invoke(Patient.ToString());
            source.Invoke(string.Empty);
        }

        source.Invoke("-------------- Expiry Date --------------");
        source.Invoke($"Date: {ExpiryDate}");
        source.Invoke(string.Empty);
    }
}