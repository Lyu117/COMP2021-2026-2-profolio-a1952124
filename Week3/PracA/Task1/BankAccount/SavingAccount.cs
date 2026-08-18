namespace Bank;
 class SavingsAccount:BankAccount
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
    }