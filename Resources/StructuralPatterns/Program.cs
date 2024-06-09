using StructuralPatterns.Prescriptions;
using StructuralPatterns.Prescriptions.Prescriptions;
using StructuralPatterns.Storage;

namespace StructuralPatterns
{
    public abstract class Program
    {
        public static void Main()
        {
            HospitalFacade facade = new();

            PrescriptionBase prescription = facade.GetFirstPrescriptionFromStorage();
            prescription.PrintDetails(source: Console.WriteLine);

            PrescriptionBase decorator = HospitalFacade.ExtendExpiryDate(
                prescription: prescription,
                additionalDays: 7);

            decorator.PrintDetails(source: Console.WriteLine);

            PrescriptionBase decorator2 = HospitalFacade.ExtendExpiryDate(
                prescription: prescription,
                additionalDays: 20);

            decorator2.PrintDetails(source: Console.WriteLine);
        }
    }
}