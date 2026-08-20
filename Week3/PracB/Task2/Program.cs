using EmployeeSystem;

class Programs{

public static void Main(){
List<Employee> employees =new List<Employee>();

employees.Add(new FullTimeEmployee("Bill", 5000m));
employees.Add(new Contractor("Fred", 20m, 100m));

foreach (Employee employee in employees)
{
    
    decimal netPay = employee.CalculatePay();
    decimal pay = netPay / (1 - Employee.TaxRate);
    decimal tax = pay * Employee.TaxRate;
    Console.WriteLine($"{employee.Name}: Pay ${pay}. Tax ${tax}.");
}
}
}
