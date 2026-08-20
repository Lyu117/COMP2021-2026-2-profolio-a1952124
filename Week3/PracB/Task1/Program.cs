namespace EmployeeSystem;

interface IReportable
{
    string GenerateReport();
}
abstract public class Employee
{
    public string Name{get;set;}
    public decimal Tax;
    public Employee(string name)
    {
        Name=name;
    }
    public const decimal TaxRate=0.2m;
    public abstract decimal CalculatePay();
    
}

public  class FullTimeEmployee : Employee, IReportable
{
    
    public decimal AnnualSalary{get;set;}
    public FullTimeEmployee(string name,decimal annualSalary) : base(name)
    {
       AnnualSalary=annualSalary;
    }

    public override decimal CalculatePay()
    {
        Tax=AnnualSalary*TaxRate;
        
        return AnnualSalary-Tax;
    }
    public string GenerateReport()
    {
        return $"Name:{Name}, AnnualSalary:{AnnualSalary}, Pay:{CalculatePay()}";
    }

}

public  class Contractor : Employee,IReportable
{
    public decimal Rate{get;set;}
    public decimal Hours{get;set;}

    public Contractor(string name,decimal rate,decimal hours) : base(name)
    {
        Rate=rate;
        Hours=hours;
    }
    public override decimal CalculatePay()

    {
        Tax=(Rate*Hours)*TaxRate;

        decimal result=(Rate * Hours)-Tax;
        return result;
    }
    public string GenerateReport()
    {
        return $"Name:{Name}, Hours:{Hours}, Rate:{Rate}, Pay:{CalculatePay()}";
    }
}

public class Programs
{
    public static void Main()
    {
        FullTimeEmployee f1=new FullTimeEmployee("Max",20000m);
        Contractor c1 =new Contractor("Jacky",50m,100m);
         Console.WriteLine(f1.GenerateReport());
          Console.WriteLine(f1.CalculatePay());
           Console.WriteLine(c1.CalculatePay());
            Console.WriteLine(c1.GenerateReport());
    }
}