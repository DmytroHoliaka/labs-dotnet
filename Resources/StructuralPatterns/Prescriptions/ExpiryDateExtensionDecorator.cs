namespace StructuralPatterns.Prescriptions.Prescriptions;

public class ExpiryDateExtensionDecorator : PrescriptionDecoratorBase
{
    public ExpiryDateExtensionDecorator(PrescriptionBase prescriptionBase,
        int additionalDays) : base(prescriptionBase)
    {
        if (additionalDays <= 0)
        {
            throw new ArgumentException("Additional days must be positive", 
                                        nameof(additionalDays));
        }

        prescriptionBase.ExpiryDate = prescriptionBase.ExpiryDate.AddDays(additionalDays);
        AttachTo(prescriptionBase);
    }
}