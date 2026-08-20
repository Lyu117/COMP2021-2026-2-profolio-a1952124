using EmployeeSystem;
using Xunit;

namespace Task3;

public class UnitTest1
{
    [Fact]
    public void TestFullTimeName()
    {
        FullTimeEmployee employee = new FullTimeEmployee("Bill", 5000m);

        Assert.Equal("Bill", employee.Name);
    }
    [Fact]
    public void TestTaxRate()
    {
    Assert.Equal(0.2m, Employee.TaxRate);
    }

    [Fact]
    public void TestFullTimeSalary()
    {
        FullTimeEmployee employee = new FullTimeEmployee("Bill", 5000m);

        Assert.Equal(5000m, employee.AnnualSalary);
    }

    [Fact]
    public void TestFullTimePay()
    {
        FullTimeEmployee employee = new FullTimeEmployee("Bill", 5000m);

        decimal result = employee.CalculatePay();

        Assert.Equal(4000m, result);
    }

    [Fact]
    public void TestFullTimeReport()
    {
        FullTimeEmployee employee = new FullTimeEmployee("Bill", 5000m);

        string result = employee.GenerateReport();

        Assert.Contains("Bill", result);
    }

    [Fact]
    public void TestContractorName()
    {
        Contractor employee = new Contractor("Fred", 20m, 100m);

        Assert.Equal("Fred", employee.Name);
    }

    [Fact]
    public void TestContractorRate()
    {
        Contractor employee = new Contractor("Fred", 20m, 100m);

        Assert.Equal(20m, employee.Rate);
    }

    [Fact]
    public void TestContractorHours()
    {
        Contractor employee = new Contractor("Fred", 20m, 100m);

        Assert.Equal(100m, employee.Hours);
    }

    [Fact]
    public void TestContractorPay0()
    {
        Contractor employee = new Contractor("Fred", 20m, 100m);

        decimal result = employee.CalculatePay();

        Assert.Equal(1600m, result);
    }
    [Fact]
    public void TestFullTimeTax()
    {
     FullTimeEmployee employee = new FullTimeEmployee("Bill", 5000m);

    employee.CalculatePay();

     Assert.Equal(1000m, employee.Tax);
    }

    [Fact]
    public void TestContractorReport()
    {
        Contractor employee = new Contractor("Fred", 20m, 100m);

        string result = employee.GenerateReport();

        Assert.Contains("Fred", result);
    }
        [Fact]
     public void TestContractorTax()
       {
    Contractor employee = new Contractor("Fred", 20m, 100m);

    employee.CalculatePay();

    Assert.Equal(400m, employee.Tax);
     }
    [Fact]
     public void TestMain()
    {
    Programs.Main();
    }
}