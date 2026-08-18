using Bank;
using Xunit;

namespace BankTests;

public class UnitTest1
{
    [Fact]
    public void BankAccountConstructorTest()
    {
        BankAccount account = new BankAccount("Max", 100m);

        Assert.Equal("Max", account.Owner);
        Assert.Equal(100m, account.Balance);
    }

    [Fact]
    public void BankAccountInvalidBalanceTest()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            new BankAccount("Max", 0m);
        });
    }

    [Fact]
    public void DepositDecimalTest()
    {
        BankAccount account = new BankAccount("Max", 100m);

        account.Deposit(20m);

        Assert.Equal(120m, account.Balance);
    }

    [Fact]
    public void DepositDecimalNegativeTest()
    {
        BankAccount account = new BankAccount("Max", 100m);

        Assert.Throws<ArgumentException>(() =>
        {
            account.Deposit(-20m);
        });
    }

    [Fact]
    public void DepositIntTest()
    {
        BankAccount account = new BankAccount("Max", 100m);

        account.Deposit(20);

        Assert.Equal(120m, account.Balance);
    }

    [Fact]
    public void DepositIntNegativeTest()
    {
        BankAccount account = new BankAccount("Max", 100m);

        Assert.Throws<ArgumentException>(() =>
        {
            account.Deposit(-20);
        });
    }

    [Fact]
    public void DepositDoubleTest()
    {
        BankAccount account = new BankAccount("Max", 100m);

        account.Deposit(20.5);

        Assert.Equal(120.5m, account.Balance);
    }

    [Fact]
    public void DepositDoubleNegativeTest()
    {
        BankAccount account = new BankAccount("Max", 100m);

        Assert.Throws<ArgumentException>(() =>
        {
            account.Deposit(-20.5);
        });
    }

    [Fact]
    public void WithdrawTest()
    {
        BankAccount account = new BankAccount("Max", 100m);

        account.Withdraw(20m);

        Assert.Equal(80m, account.Balance);
    }

    [Fact]
    public void WithdrawTooMuchTest()
    {
        BankAccount account = new BankAccount("Max", 100m);

        Assert.Throws<ArgumentException>(() =>
        {
            account.Withdraw(200m);
        });
    }

    [Fact]
    public void SavingsAccountTest()
    {
        SavingsAccount account =
            new SavingsAccount("Max", 1000m, 0.05m);

        Assert.Equal(0.05m, account.InterestRate);

        account.ApplyInterest();

        Assert.Equal(1050m, account.Balance);

        account.DisplayAccountInfo();
    }

    [Fact]
    public void CheckingAccountTest()
    {
        CheckingAccount account =
            new CheckingAccount("Max", 1000m, 5m);

        Assert.Equal(5m, account.Fee);

        account.WithdrawWithFee(100m);

        Assert.Equal(895m, account.Balance);

        account.DisplayAccountInfo();
    }

    [Fact]
    public void CheckingAccountNotEnoughMoneyTest()
    {
        CheckingAccount account =
            new CheckingAccount("Max", 100m, 5m);

        Assert.Throws<ArgumentException>(() =>
        {
            account.WithdrawWithFee(100m);
        });
    }

    [Fact]
    public void BankAccountDisplayTest()
    {
        BankAccount account =
            new BankAccount("Max", 100m);

        account.DisplayAccountInfo();
    }
}