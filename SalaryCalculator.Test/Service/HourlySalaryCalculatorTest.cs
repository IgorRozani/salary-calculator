using SalaryCalculator.Service.CalculatorFactory;
using Xunit;

namespace SalaryCalculator.Test.Service
{
    public class HourlySalaryCalculatorTest
    {
        private HourlySalaryCalculator _hourlySalaryCalculator;

        public HourlySalaryCalculatorTest()
        {
            _hourlySalaryCalculator = new HourlySalaryCalculator();
        }

        [Fact]
        public void Calulate()
        {
            var employee = new SalaryCalculator.Service.Model.Employee { HourlySalary = 60 };

            var salary = _hourlySalaryCalculator.Calculate(employee);

            Assert.Equal(86400, salary);
        }
    }
}
