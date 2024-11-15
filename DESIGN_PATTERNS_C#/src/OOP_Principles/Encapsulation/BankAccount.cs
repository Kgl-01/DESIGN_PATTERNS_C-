
namespace DESIGN_PATTERNS_C_.src.OOP_Principles.Encapsulation;

public class BankAccount
{
    private decimal _balance;

    public BankAccount(decimal balance)
    {
        Deposit(balance);
    }

    public BankAccount()
    {
        Deposit(0);
    }


    public decimal GetBalance()
    {
        return _balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Deposit amount must be positive");
        }
        this._balance += amount;
        System.Console.WriteLine($"Remaining Balance: {this._balance}");
    }

    public void Withdraw(decimal amount)
    {

        if (amount < 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }
        if (amount > this._balance)
        {
            throw new InvalidOperationException("Insufficient funds");
        }

        this._balance -= amount;
        System.Console.WriteLine($"Remaining Balance: {this._balance}");
    }
}
