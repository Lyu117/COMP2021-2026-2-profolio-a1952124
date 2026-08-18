using System.Buffers;
using System.Dynamic;

namespace Bank
{
    public class BankAccount
    {
        public string Owner {get;set;}
        public decimal Balance {get;set;}

        public BankAccount(string owner, decimal blance)
        {
            if (blance <= 0)
            {
                throw new ArgumentException("Empty balance. ");

            }

            Owner=owner;
            Balance=blance;
            
        }
       public decimal Deposit(decimal amount)
        {
            decimal result;
            if (amount < 0)
            {
                throw new ArgumentException("Amount can not be negative.");
                
            }
            result=Balance+amount;
            Balance=result;
            return Balance;

            
        }


       public decimal Deposit(int amount)
        {
            decimal result;
            if (amount < 0)
            {
                throw new ArgumentException("Amount can not be negative.");
                
            }
            result=Balance+amount;
            Balance=result;
            return Balance;

            
        }

       public decimal Deposit(double amount)
        {
            decimal result;
            if (amount < 0)
            {
                throw new ArgumentException("Amount can not be negative.");
                
            }
            result=(decimal)Balance+(decimal)amount;
            Balance=result;
            return Balance;

            
        }
        public decimal Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new ArgumentException("You do not have so much money.");

            }
            decimal result;
            result=Balance-amount;
            Balance=result;
            return Balance;
        }
                    
        

        

    }
    class Program
    {
        public static void Main()
        {
            BankAccount b1 = new BankAccount("MAX",60);
            b1.Deposit(10);
            Console.WriteLine($"Your balance now is {b1.Balance}(int)");
            b1.Withdraw(5);
            Console.WriteLine($"Your balance now is {b1.Balance}");
            
            b1.Deposit(10.5);
            Console.WriteLine($"Your balance now is {b1.Balance}(double)");
            b1.Deposit(10m);
            Console.WriteLine($"Your balance now is {b1.Balance}(decimal)");
            b1.Withdraw(100);
            Console.WriteLine($"Your balance now is {b1.Balance}");

            
        }

    }

    class SavingsAccount:BankAccount
    {
        decimal InterestRate;
        public  SavingsAccount(string owner,decimal balance,decimal interestRate)
            : base(owner, balance)
        {
            InterestRate = interestRate;

        }
        public decimal ApplyInterest(decimal interestRate)
        {
            decimal interest;
            interest=Balance*interestRate;
            Balance+=interest;
            return Balance;
            
        }
    }
}