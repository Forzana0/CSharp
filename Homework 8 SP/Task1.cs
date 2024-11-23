using System;
using System.Threading;

class BankAccount
{
    private decimal balance;

    public BankAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }
    public void Withdraw(decimal amount)
    {
        Monitor.Enter(this);
        try
        {
            if (balance >= amount)
            {
                Console.WriteLine($"Processing withdrawal of {amount:C}. Balance before withdrawal: {balance:C}");
                Thread.Sleep(500);
                balance -= amount;
                Console.WriteLine($"Withdrawal of {amount:C} successful. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine($"Insufficient funds for withdrawal of {amount:C}. Current balance: {balance:C}");
            }
        }
        finally
        {
            Monitor.Exit(this);
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(1000);

        Thread t1 = new Thread(() => account.Withdraw(500));
        Thread t2 = new Thread(() => account.Withdraw(700));
        Thread t3 = new Thread(() => account.Withdraw(200));

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();
    }
}
