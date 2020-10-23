using SalaryCalculator.Repository.Interface;
using SalaryCalculator.Service.CalculatorFactory.Interface;
using SalaryCalculator.Service.Interface;
using SalaryCalculator.Service.Model;
using System.Collections.Generic;
using System.Linq;

namespace SalaryCalculator.Service.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ICalculatorFactory _salaryCalculatorFactory;

        public EmployeeService(IEmployeeRepository employeeRepository, ICalculatorFactory calculatorFactory)
        {
            _employeeRepository = employeeRepository;
            _salaryCalculatorFactory = calculatorFactory;
        }


        public List<Employee> GetAll()
        {
            var employees = _employeeRepository.Get();

            return employees.Select(ConvertEmployeeToModel).ToList();
        }

        private Employee ConvertEmployeeToModel(Repository.Model.Employee employee)
        {
            Employee employeeModel = employee;
            employeeModel.AnualSalary = _salaryCalculatorFactory.Get(employeeModel.ContractType).Calculate(employeeModel);

            return employeeModel;
        }

        public Employee Get(int id)
        {
            var employees = GetAll();

            return employees.FirstOrDefault(e => e.Id == id);
        }
    }
}
