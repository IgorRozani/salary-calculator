using SalaryCalculator.Service.Enum;

namespace SalaryCalculator.Service.CalculatorFactory.Interface
{
    public interface ICalculatorFactory
    {
        ICalculator Get(ContractType contractType);
    }
}
