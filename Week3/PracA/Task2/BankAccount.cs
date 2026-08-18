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
        public  decimal Withdraw(decimal amount)
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
        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine($"Owner: {Owner}");
            Console.WriteLine($"Balance:{Balance}");
            
        }
    }
}