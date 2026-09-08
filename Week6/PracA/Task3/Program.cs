using System.ComponentModel.DataAnnotations;

namespace Task3;
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
class Progress
{
    public static void Main()
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

        Stack<BankAccount>account=new Stack<BankAccount>();
        account.Push(a1);
        account.Push(a2);
        account.Push(a3);
        account.Push(a4);
        account.Push(a5);
        account.Push(a6);
        account.Push(a7);
        account.Push(a8);
        account.Push(a9);
        account.Push(a10);
        System.Console.WriteLine("The Stack<BankAccount> is ");
        System.Console.WriteLine();

        foreach(BankAccount account1 in account)
        {
            System.Console.WriteLine(account1);
        }
        StackToQueue(account);



    }
    public static Queue<BankAccount> StackToQueue(Stack<BankAccount>account)
    {
        Queue<BankAccount>accountQueue=new Queue<BankAccount>();
        foreach(BankAccount account1 in account)
        {
            accountQueue.Enqueue(account1);
        }
        System.Console.WriteLine();

        System.Console.WriteLine("AccountQueue is ");
        System.Console.WriteLine();

        foreach (BankAccount account2 in accountQueue)
        {
            System.Console.WriteLine(account2);
        }
        System.Console.WriteLine();
      
        return accountQueue;

    }
}