using Bank;

namespace Bank.Tests;

public class BankAccountTests
{
    [Fact]
    public void Constructor_SetsOwnerAndBalance()
    {
        Bank.BankAccount account = new Bank.BankAccount("Max", 60);

        Assert.Equal("Max", account.Owner);
        Assert.Equal(60m, account.Balance);
    }

    [Fact]
    public void Constructor_InvalidBalance_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
            new BankAccount("Max", 0));
    }

    [Fact]
    public void Deposit_Decimal_AddsMoney()
    {
        BankAccount account = new BankAccount("Max", 60);

        account.Deposit(10.5m);

        Assert.Equal(70.5m, account.Balance);
    }

    [Fact]
    public void Deposit_Decimal_Negative_ThrowsException()
    {
        BankAccount account = new BankAccount("Max", 60);

        Assert.Throws<ArgumentException>(() =>
            account.Deposit(-10.5m));
    }

    [Fact]
    public void Deposit_Int_AddsMoney()
    {
        BankAccount account = new BankAccount("Max", 60);

        account.Deposit(10);

        Assert.Equal(70m, account.Balance);
    }

    [Fact]
    public void Deposit_Int_Negative_ThrowsException()
    {
        BankAccount account = new BankAccount("Max", 60);

        Assert.Throws<ArgumentException>(() =>
            account.Deposit(-10));
    }

    [Fact]
    public void Deposit_Double_AddsMoney()
    {
        BankAccount account = new BankAccount("Max", 60);

        account.Deposit(10.5);

        Assert.Equal(70.5m, account.Balance);
    }

    [Fact]
    public void Deposit_Double_Negative_ThrowsException()
    {
        BankAccount account = new BankAccount("Max", 60);

        Assert.Throws<ArgumentException>(() =>
            account.Deposit(-10.5));
    }

    [Fact]
    public void Withdraw_ReducesBalance()
    {
        BankAccount account = new BankAccount("Max", 60);

        account.Withdraw(20m);

        Assert.Equal(40m, account.Balance);
    }

    [Fact]
    public void Withdraw_TooMuch_ThrowsException()
    {
        BankAccount account = new BankAccount("Max", 60);

        Assert.Throws<ArgumentException>(() =>
            account.Withdraw(100m));
    }
}