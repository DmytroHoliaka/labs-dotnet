using BehavioralPatterns.Entities;
using BehavioralPatterns.Factory;

namespace BehavioralPatterns.Commands;

public class RentalEquipmentCommand : RentalCommand
{
    private bool _isPaid;
    private int _totalPrice;

    public RentalEquipmentCommand(RentalCard? rentalCard) : base(rentalCard)
    {
        Strategy = PriceStrategyFactory.CreatePriceStrategy(
            condition: RentalCard.Condition);

        _isPaid = false;
    }

    public override void Execute()
    {
        ArgumentNullException.ThrowIfNull(Strategy);

        int price = Strategy.CalculatePrice(
            equipmentName: RentalCard.Equipment,
            duration: RentalCard.Duration);

        if (price == 0)
        {
            return;
        }

        if (TryToPay(fundsToPay: price))
        {
            _isPaid = true;
            _totalPrice = price;
            RentalCard.RentalDate = DateTime.Now;
            Console.WriteLine($"The payment ({_totalPrice / 100}$) was successful.");
        }
        else
        {
            Console.WriteLine($"Error. There are not enough funds (should be {price / 100}$) " +
                              $"on the account (have only {RentalCard.Account.Balance / 100}$).");
        }
    }

    public override void Undo()
    {
        if (_isPaid == false)
        {
            Console.WriteLine("It is not possible to cancel, the rent has not been paid.");
            return;
        }

        int elapsedHours = (DateTime.Now - RentalCard.RentalDate).Hours;

        if (elapsedHours >= RentalCard.Duration)
        {
            Console.WriteLine("The rental period has expired, there are no refunds.");
            return;
        }

        int spentFunds = _totalPrice / RentalCard.Duration * elapsedHours;
        int returnFunds = _totalPrice - spentFunds;

        ReturnFunds(fundsToReturn: returnFunds);
        Console.WriteLine($"The funds ({returnFunds / 100}$) were successfully returned.");
    }

    private bool TryToPay(int fundsToPay)
    {
        if (RentalCard.Account.Balance < fundsToPay)
        {
            return false;
        }

        RentalCard.Account.Balance -= fundsToPay;
        return true;
    }

    private void ReturnFunds(int fundsToReturn)
    {
        RentalCard.Account.Balance += fundsToReturn;
    }
}