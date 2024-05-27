using System.Data;

namespace BehavioralPatterns.Entities;

public class RentalCard
{
    public readonly Guid CardId;
    public readonly Account Account;
    public readonly string Equipment;
    public readonly string Condition;
    public readonly int Duration;
    public DateTime RentalDate
    {
        get => _rentalDate;
        set
        {
            if (_rentalDate != DateTime.MinValue)
            {
                throw new DataException("The rental date is set only once.");
            }

            _rentalDate = value;
        }
    }

    private DateTime _rentalDate;

    public RentalCard(
        Guid cardId, 
        Account? account, 
        string? equipment, 
        string? condition, 
        int duration)
    {
        ArgumentNullException.ThrowIfNull(account);
        ArgumentNullException.ThrowIfNull(equipment);
        ArgumentNullException.ThrowIfNull(condition);

        CardId = cardId;
        Account = account;
        Equipment = equipment;
        Condition = condition;
        Duration = duration;
    }
}