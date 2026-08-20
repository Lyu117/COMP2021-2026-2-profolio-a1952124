namespace EmployeeSystem;
abstract public class Employee
{
    public string Name{get;set;}
    public Employee(string name)
    {
        Name=name;
    }
    public const decimal TaxRate=0.2m;
}

public class FullTimeEmployee : Employee
{
    public FullTimeEmployee(string name) : base(name)
    {
        Name=name;
    }
    public decimal AnnualSalary{get;set;}

}

public class Contractor : Employee
{
    public Contractor(string name):
}