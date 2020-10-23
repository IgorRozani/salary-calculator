using SalaryCalculator.Service.CalculatorFactory;
using Xunit;

namespace SalaryCalculator.Test.Service
{
    public class MonthlySalaryCalculatorTest
    {
        private MonthlySalaryCalculator _monthlySalaryCalculator;

        public MonthlySalaryCalculatorTest()
        {
            _monthlySalaryCalculator = new MonthlySalaryCalculator();
        }

        [Fact]
        public void Calculate()
        {
            var employee = new SalaryCalculator.Service.Model.Employee { MonthlySalary = 6000 };

            var result = _monthlySalaryCalculator.Calculate(employee);

            Assert.Equal(72000, result);
        }
    }
}
