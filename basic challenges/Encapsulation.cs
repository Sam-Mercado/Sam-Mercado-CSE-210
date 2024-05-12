
using System;

class BankAccount
{
    private decimal _balance;
    
    public BankAccount(decimal initialBalance)
    {
        _balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        _balance = _balance + amount;
    }

    public void Withdraw(decimal amount)
    {
        if (_balance >= amount)
        {
            _balance = _balance - amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public string GetBalance()
    {
        return "Current Balance: " + _balance;
    }
}

class Program {
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(1000m); // Initial balance of $1000
        account.Deposit(500m); // Deposit $500
        account.Withdraw(200m); // Withdraw $200
        Console.WriteLine(account.GetBalance()); // Print the balance, should output $1300

        account.Withdraw(1500m); // Attempt to withdraw $1500, should fail due to insufficient funds
    }
}