namespace BehavioralPatterns.Entities;

public class Account
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Balance { get; set; }

    public override string ToString()
    {
        return $"""
               Name: {FirstName} {LastName}
               Balance: {Balance / 100}$
               """;
    }
}