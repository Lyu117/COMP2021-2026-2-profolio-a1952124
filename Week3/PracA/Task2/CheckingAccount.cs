namespace Bank;
public class CheckingAccount : BankAccount
    {
        public decimal Fee{get;set;}
        public CheckingAccount(string owner,decimal balance,decimal fee) : base(owner, balance)
        {
            Fee=fee;
        }
        public decimal WithdrawWithFee(decimal amount)
        {
            return base.Withdraw(amount+Fee);
        }
        public override void DisplayAccountInfo()

            {
        Console.WriteLine("Account: CheckingAccount");
        base.DisplayAccountInfo();
        Console.WriteLine($"Transaction fee: {Fee}");
     }
    }

     