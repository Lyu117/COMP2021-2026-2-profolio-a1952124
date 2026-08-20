namespace EmployeeSystem;

interface IReportable
{
    string GenerateReport();
}
abstract public class Employee
{
    public string Name{get;set;}
    public Employee(string name)
    {
        Name=name;
    }
    public const decimal TaxRate=0.2m;
    
}

public class FullTimeEmployee : Employee, IReportable
{
    public decimal AnnualSalary{get;set;}
    public FullTimeEmployee(string name,decimal annualSalary) : base(name)
    {
       AnnualSalary=annualSalary;
    }

    public decimal CalculatePay()
    {
        decimal Tax=AnnualSalary*TaxRate;
        
        return AnnualSalary-Tax;
    }
    public string GenerateReport()
    {
        return $"Name:{Name}, AnnualSalary:{AnnualSalary}, PayTax:{CalculatePay()}";
    }

}

public class Contractor : Employee
{
    public decimal Rate{get;set;}
    public decimal Hours{get;set;}

    public Contractor(string name,decimal rate,decimal hours) : base(name)
    {
        Rate=rate;
        Hours=hours;
    }
}