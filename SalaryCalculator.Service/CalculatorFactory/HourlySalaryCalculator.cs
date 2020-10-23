using SalaryCalculator.Service.Model;
using SalaryCalculator.Service.CalculatorFactory.Interface;

namespace SalaryCalculator.Service.CalculatorFactory
{
    public class HourlySalaryCalculator : ICalculator
    {
        public decimal Calculate(Employee employee)
        {
            return (120 * employee.HourlySalary) * 12;
        }
    }
}
