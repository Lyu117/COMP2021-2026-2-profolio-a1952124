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
            
        }

        

    }
}