class Program
{
    private const double TAX_RATE = 0.2;

    static double CalculatePay(double hours, double rate)
    {
        if (hours < 0 || rate < 0)
        {
            throw new ArgumentException(
                "Hours and rate must be positive."
            );
        }

        double gross = hours * rate;
        double tax = gross * TAX_RATE;
        double net = gross - tax;

        return net;
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Hours worked: ");
            if (!double.TryParse(
                    Console.ReadLine(),
                    out double hours))
            {
                throw new FormatException(
                    "Hours must be a number."
                );
            }

            Console.Write("Hourly rate: ");
            if (!double.TryParse(
                    Console.ReadLine(),
                    out double rate))
            {
                throw new FormatException(
                    "Hourly rate must be a number."
                );
            }

            double netPay = CalculatePay(hours, rate);

            Console.WriteLine(
                $"{name} earned ${netPay:F2} after tax."
            );
        }
        catch (FormatException ex)
        {
            Console.WriteLine(
                $"Input error: {ex.Message}"
            );
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(
                $"Value error: {ex.Message}"
            );
        }
    }
}