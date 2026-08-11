using Xunit;

namespace Task3
{
    public class PayrollTests
    {
        [Fact]
        public void Constructor_SetsValues()
        {
            Payroll.Payroll p = new Payroll.Payroll(40, 25m, 0.2m);

            Assert.Equal(40, p.Hours);
            Assert.Equal(25m, p.Rate);
            Assert.Equal(0.2m, p.TaxRate);
        }


        [Fact]
        public void CalculateNetPay_ReturnsCorrectValue()
        {
            Payroll.Payroll p = new Payroll.Payroll(40, 25m, 0.2m);

            decimal result = p.CalculateNetPay();

            Assert.Equal(800m, result);
        }


        [Fact]
        public void ChangeTaxRate_ChangesTaxRate()
        {
            Payroll.Payroll p = new Payroll.Payroll(40, 25m, 0.2m);

            p.ChangeTaxRate(0.25m);

            Assert.Equal(0.25m, p.TaxRate);
        }


        [Fact]
        public void NegativeHours_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
                new Payroll.Payroll(-1, 25m, 0.2m));
        }


        [Fact]
        public void NegativeRate_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
                new Payroll.Payroll(40, -1m, 0.2m));
        }


        [Fact]
        public void NegativeTaxRate_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
                new Payroll.Payroll(40, 25m, -0.2m));
        }


        [Fact]
        public void NegativeNewTaxRate_ThrowsException()
        {
            Payroll.Payroll p = new Payroll.Payroll(40, 25m, 0.2m);

            Assert.Throws<ArgumentException>(() =>
                p.ChangeTaxRate(-0.1m));
        }
    }
}