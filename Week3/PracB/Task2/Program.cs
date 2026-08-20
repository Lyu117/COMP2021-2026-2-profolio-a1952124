using EmployeeSystem;

class Programs{

public static void Main(){
List<Employee> employees =new List<Employee>();

employees.Add(new FullTimeEmployee("Bob", 6250m));
employees.Add(new Contractor("Fred", 25m, 100m));

foreach (Employee employee in employees)
{
    decimal netPay = employee.CalculatePay();
    decimal tax = netPay / (1 - Employee.TaxRate) * Employee.TaxRate;

    Console.WriteLine($"{employee.Name}: Pay ${netPay}. Tax ${tax}.");
}
}
}
