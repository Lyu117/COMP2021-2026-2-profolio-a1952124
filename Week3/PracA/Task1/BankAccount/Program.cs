namespace Bank;
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
            b1.Withdraw(10);
            Console.WriteLine($"Your balance now is {b1.Balance}");


            SavingsAccount s1 =new SavingsAccount("Max",1000,0.05m);
            CheckingAccount c1=new CheckingAccount("Maaax",1200,5m);
            s1.ApplyInterest();
            Console.WriteLine($"Savings Account Balance: {s1.Balance}");
            c1.WithdrawWithFee(100);
            Console.WriteLine($"Checking Account Balance : {c1.Balance}");

        }

    }