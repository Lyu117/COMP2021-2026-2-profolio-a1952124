namespace Payroll
{
    public class Payroll
    {

        private double _hours;
        private decimal _rate;
        private decimal _taxRate;


       // hours Property
        public double Hours
        {
            get
            {
                return _hours;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours can not be negative.");

                }
                _hours=value;
            }
        }
        // rate property
        public decimal Rate
        {
            get
            {
                return _rate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Rate cannot be negative.");
                }

                _rate = value;
            }
        }


        // TaxRate Property
        public decimal TaxRate
        {
            get
            {
                return _taxRate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("TaxRate cannot be negative.");
                }

                _taxRate = value;
            }
        }
       public Payroll(double hours, decimal rate,decimal taxRate)
        {
           

            Hours = hours;
            Rate = rate;
            TaxRate = taxRate;
        }

        //Method of CaculateNetPay
        public decimal CalculateNetPay()
        {
             decimal grossPay = (decimal)_hours * Rate;

             decimal tax = grossPay * TaxRate;

             decimal netPay = grossPay - tax;

             return netPay;

        }


        //Method of change tax rate

        public void ChangeTaxRate(
            decimal newTaxRate)
        { 
            TaxRate = newTaxRate;
            
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