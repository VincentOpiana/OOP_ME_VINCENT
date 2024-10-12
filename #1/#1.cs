using System;

namespace ConsoleApp1.Exam
{
    // Bank Account Class
    public class BankAccount
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($" Deposited         : {amount:C}.");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public string Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                return $" Withdrew          : {amount:C}\n Remaining balance : {balance:C}.";
            }
            else if (amount > balance)
            {
                return "Insufficient funds.";
            }
            else
            {
                return "Withdrawal amount must be positive.";
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
  
            BankAccount account = new BankAccount();

            Console.WriteLine();
            Console.WriteLine(" Name : Vincent Lloyd M. Opiana ");
            Console.WriteLine();
            Console.WriteLine(" ======== Bank account ======== ");
            Console.WriteLine();

    
            account.Deposit(100); 
            Console.WriteLine(account.Withdraw(30));



            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }

    }
}
