namespace tasks;

public class Program
{
   static void Main(string[] args)
    {
        BankAccount b = new BankAccount("ACC123", 5000);
        Console.WriteLine("Account Number: " + b.AccountNumber);
        b.Deposit(2000);
        b.Withdraw(1500);
        Console.WriteLine("Remaining Balance: " + b.Balance);
    }
}
