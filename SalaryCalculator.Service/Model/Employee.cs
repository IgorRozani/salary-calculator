using SalaryCalculator.Service.Enum;

namespace SalaryCalculator.Service.Model
{
    public class Employee
    {
        public Employee()
        {
            Role = new Role();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ContractType ContractType { get; set; }
        public Role Role { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal AnualSalary { get; set; }

        public static implicit operator Employee(Repository.Model.Employee employee)
        {
            return new Employee
            {
                Id = employee.Id,
                Name = employee.Name,
                ContractType = (ContractType)System.Enum.Parse(typeof(ContractType), employee.ContractTypeName),
                Role = new Role
                {
                    Id = employee.RoleId,
                    Name = employee.RoleName,
                    Description = employee.RoleDescription
                },
                HourlySalary = employee.HourlySalary,
                MonthlySalary = employee.MonthlySalary
            };
        }
    }
}
