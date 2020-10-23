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
    }
}
