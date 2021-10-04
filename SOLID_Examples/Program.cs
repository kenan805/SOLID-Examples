using System;

namespace SOLID_Examples
{
    //S - Single responsibility principle

    public class BankAccount //Burda yalniz accountun oz propertileri var.
    {

        public string AccountNumber { get; set; }
        public double AccountBalance { get; set; }

        public BankAccount(string accountNumber, double accountBalance)
        {
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
        }

    }

    public class InterstCalculator //Bu class accountun faiz hesablama isini bu metod gorur.
    {
        public double CalculateInterest(BankAccount account)
        {
            Console.WriteLine($"Account number: {account.AccountNumber} --> calculate interest...");
            return 100;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("12345", 3456.20);
            InterstCalculator calculator = new InterstCalculator();
            Console.WriteLine($"Account number: {account.AccountNumber} --> {calculator.CalculateInterest(account)}");
        }
    }


}
