using System; 

namespace ConsoleApp1.Exam
{
    
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
                Console.WriteLine($"Deposited {amount:C}. New balance is {balance:C}.");
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
                return $"Withdrew {amount:C}. Remaining balance is {balance:C}.";
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

        public void Transfer(BankAccount target, decimal amount)
        {
            if (this.Balance >= amount)
            {
                string withdrawalResult = Withdraw(amount);
                if (withdrawalResult.Contains("Withdrew"))
                {
                    target.Deposit(amount);
                    Console.WriteLine($"Transferred {amount:C} to the target account.");
                }
            }
            else
            {
                Console.WriteLine("Insufficient balance for transfer.");
            }
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
           
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount();


            Console.WriteLine();
            Console.WriteLine(" ======== Bank account ======== ");
            Console.WriteLine();
            account1.Deposit(500);
            Console.WriteLine(account1.Withdraw(100));
            Console.WriteLine();

            account2.Deposit(200);
            Console.WriteLine();
            account1.Transfer(account2, 150);

            Console.WriteLine();
            Console.WriteLine($"Wally balance: {account1.Balance:C}");
            Console.WriteLine($"Jack balance: {account2.Balance:C}");

           
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}