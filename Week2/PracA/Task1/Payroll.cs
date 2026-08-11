namespace Payroll
{
    class Payroll
    {
       private double _hours;
       private decimal _rate;

       private decimal _taxRate;

       public Payroll(double hours, decimal rate,decimal taxRate)
        {
           

            if (hours < 0)

            {
            throw new ArgumentException("Hours cannot be negative.");
            }

            if (rate < 0)
            {
                throw new ArgumentException("rates cannot be negative.");
            }

            if (taxRate < 0)
            {
                throw new ArgumentException("taxRate can not be negative.");
            }


             _hours=hours;

            _rate=rate;

            _taxRate=taxRate;




        }

//Method of CaculateNetPay
        public decimal CalculateNetPay()
        {
             decimal grossPay = (decimal)_hours * _rate;

             decimal tax = grossPay * _taxRate;

             decimal netPay = grossPay - tax;

             return netPay;

        }


        //Method of change tax rate

        public void ChangeTaxRate(
            decimal newTaxRate)
        { 
            if (newTaxRate < 0)
            {
                throw new ArgumentException("The newTaxRate can not be negative.");


            }

            _taxRate=newTaxRate;
            
        }

        

       



    }
    class Program
    {
        static void Main()
        {
             Payroll p1 = new Payroll(40,25m,0.2m);
             Console.WriteLine(p1.CalculateNetPay());


            p1.ChangeTaxRate(0.25m);

             Console.WriteLine(p1.CalculateNetPay());


        }
    }
}