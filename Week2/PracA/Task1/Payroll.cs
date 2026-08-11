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


        public decimal CalculateNetPay()
        {
             decimal grossPay = (decimal)_hours * _rate;

             decimal tax = grossPay * _taxRate;

             decimal netPay = grossPay - tax;

    return netPay;
        }

        

       



    }
    class Program
    {
        static void Main()
        {
             Payroll p1 = new Payroll(40,25m,0.2m);


        }
    }
}