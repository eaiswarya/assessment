using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
public class BankAccount
{
    public string AccountNumber;
    public string AccountHolderName;

    public decimal Balance;

    public BankAccount(string accountNo, string accountHolder, decimal initialBalance = 0)
    {
        Console.WriteLine("Enter account number:");
        accountNo = Console.ReadLine();
        Console.WriteLine("Enter account holder name:");
        accountHolder = Console.ReadLine();

        if (string.IsNullOrEmpty(accountHolder))
            throw new ArgumentException("Account Holder name cant be empty or null", nameof(accountHolder));

        if (string.IsNullOrEmpty(accountNo))
            throw new ArgumentException("Acount number cant be empty or null", nameof(accountNo));

        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cant be less than zero", nameof(initialBalance));

        AccountNumber = accountNo;
        AccountHolderName = accountHolder;
        Balance = initialBalance;
    }
    public bool Withdrawel(decimal amount)
    {
        if (amount < 0)
            throw new ArgumentException("withdrawel amount must be greaterthan zero", nameof(amount));
        if (amount > Balance)
            return false;

        Balance -= amount;
        return true;
    }
    public void DisplayAccount()
    {
        Console.WriteLine("Account Number:{AccountNumber}");
        Console.WriteLine("Account Holder:{AccoundHolderName}");

    }
}
}
