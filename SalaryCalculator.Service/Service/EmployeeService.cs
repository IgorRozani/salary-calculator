using SalaryCalculator.Repository.Interface;
using SalaryCalculator.Service.CalculatorFactory.Interface;
using SalaryCalculator.Service.Enum;
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
            var contractType = (ContractType)System.Enum.Parse(typeof(ContractType), employee.ContractTypeName);
            var employeeModel = new Employee
            {
                Id = employee.Id,
                Name = employee.Name,
                ContractType = contractType,
                Role = new Role
                {
                    Id = employee.RoleId,
                    Name = employee.RoleName,
                    Description = employee.RoleDescription
                },
                HourlySalary = employee.HourlySalary,
                MonthlySalary = employee.MonthlySalary,
            };
            employeeModel.AnualSalary = _salaryCalculatorFactory.Get(contractType).Calculate(employeeModel);

            return employeeModel;
        }

        public Employee Get(int id)
        {
            var employees = GetAll();

            return employees.FirstOrDefault(e => e.Id == id);
        }
    }
}
