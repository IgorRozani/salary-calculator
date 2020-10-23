using SalaryCalculator.Service.CalculatorFactory.Interface;
using SalaryCalculator.Service.Enum;

namespace SalaryCalculator.Service.CalculatorFactory
{
    public class CalculatorFactory : ICalculatorFactory
    {
        public ICalculator Get(ContractType contractType)
        {
            if (contractType == ContractType.HourlySalaryEmployee)
                return new HourlySalaryCalculator();
            return new MonthlySalaryCalculator();
        }
    }
}
