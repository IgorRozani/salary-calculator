using SalaryCalculator.Service.Model;

namespace SalaryCalculator.Service.CalculatorFactory.Interface
{
    public interface ICalculator
    {
        decimal Calculate(Employee employee);
    }
}
