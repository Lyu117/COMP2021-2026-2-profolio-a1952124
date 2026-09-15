namespace Bank;


public class BankAccount(string owner, decimal balance)
{
  public string Owner { get; set; } = owner;
  public decimal Balance { get; set; } = balance;

  public decimal Deposit(decimal amount)
  {
    if (amount < 0)
    {
      throw new ArgumentException("Amount must not be negative.");
    }
    return Balance += amount;
  }

  public decimal Deposit(int amount)
  {
    return Deposit((decimal)amount);
  }

  public decimal Deposit(double amount)
  {
    return Deposit((decimal)amount);
  }

  public virtual decimal Withdraw(decimal amount)
  {
    if (amount < 0)
    {
      throw new ArgumentException("Amount must not be negative.");
    }
    if (Balance < amount)
    {
      throw new ArgumentException("Balance is less than amount");
    }
    return Balance -= amount;
  }

  public override string ToString()
  {
    string info = $"""
      Account: {nameof(BankAccount)}
      Owner: {Owner}
      Balance: {Balance:F2}
      """;
    return info;
  }


}

public class BankComparer : IComparer<BankAccount>
{
    public int Compare(BankAccount x, BankAccount y)
    {
        int balanceCompare = x.Balance.CompareTo(y.Balance);
        if (balanceCompare != 0)
        {
            return balanceCompare;
        }
        int ownerCompare = x.Owner.CompareTo(y.Owner);
        return ownerCompare;
    }
}
   class SortPrac
{
    public static void DisplayAccounts(SortedSet<BankAccount> accounts)
    {
        Console.WriteLine("SortedSet is:");

        foreach (BankAccount account in accounts)
        {
            Console.WriteLine(account);
        }
    }
}


   class Progress{

    static void Main()
    {
        BankAccount a1 = new BankAccount("Lewis Hamilton",20000);
        BankAccount a2 = new BankAccount("Max Verstappen",100000);
        BankAccount a3 = new BankAccount("Charles Leclerc",40000);
        BankAccount a4 = new BankAccount("Lando Norris", 9000000);
        BankAccount a5 = new BankAccount("George Russell",80000);
        BankAccount a6 = new BankAccount("Fernando Alonso",1100000);
        BankAccount a7 = new BankAccount("Oscar Piastri",4000000);
        BankAccount a8 = new BankAccount("Yuki Tsunoda", 9000);
        BankAccount a9 = new BankAccount("Carlos Sainz",100002000);
        BankAccount a10 = new BankAccount("Guanyu Zhou", 80000);

        SortedSet<BankAccount>accounts=new SortedSet<BankAccount>(new BankComparer());
        accounts.Add(a1);
        accounts.Add(a2);
        accounts.Add(a3);
        accounts.Add(a4);
        accounts.Add(a5);
        accounts.Add(a6);
        accounts.Add(a7);
        accounts.Add(a8);
        accounts.Add(a9);
        accounts.Add(a10);
        SortPrac.DisplayAccounts(accounts);


        
    }
}
