using SalaryCalculator.Service.CalculatorFactory.Interface;
using SalaryCalculator.Service.Model;

namespace SalaryCalculator.Service.CalculatorFactory
{
    public class MonthlySalaryCalculator : ICalculator
    {
        public decimal Calculate(Employee employee)
        {
            return employee.MonthlySalary * 12;
        }
    }
}
