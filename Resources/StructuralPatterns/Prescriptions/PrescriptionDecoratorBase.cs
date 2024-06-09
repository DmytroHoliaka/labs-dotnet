namespace StructuralPatterns.Prescriptions;

public abstract class PrescriptionDecoratorBase : PrescriptionBase
{
    private PrescriptionBase? _prescriptionBase;

    protected PrescriptionDecoratorBase(PrescriptionBase prescriptionBase)
    {
        AttachTo(prescriptionBase);
    }

    public override void PrintDetails(Action<string>? source)
    {
        _prescriptionBase?.PrintDetails(source);
    }

    protected void AttachTo(PrescriptionBase prescriptionBase)
    {
        _prescriptionBase = prescriptionBase;
    }
}