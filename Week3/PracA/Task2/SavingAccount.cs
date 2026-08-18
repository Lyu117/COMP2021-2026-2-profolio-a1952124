namespace Bank;
 public class SavingsAccount:BankAccount
    {
       public decimal InterestRate{get;private set;}
        public  SavingsAccount(string owner,decimal balance,decimal interestRate)
            : base(owner, balance)
        {
            InterestRate = interestRate;

        }
        public decimal ApplyInterest()
        {
            decimal interest;
            interest=Balance*InterestRate;
            Balance+=interest;
            return Balance;
            
        }
        public override void DisplayAccountInfo()
    {
        Console.WriteLine($"Owner: {Owner}");
        Console.WriteLine($"Balance:{Balance}");
        Console.WriteLine("Account: SavingsAccount");
        
        Console.WriteLine($"Interest rate: {InterestRate}");

    }
    }