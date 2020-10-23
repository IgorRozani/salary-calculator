using SalaryCalculator.Service.Model;
using System.ComponentModel;

namespace SalaryCalculator.Web.Models
{
    public class EmployeeDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayName("Anual salary")]
        public string AnualSalary { get; set; }
        [DisplayName("Contract Type")]
        public string ContractTypeName { get; set; }
        [DisplayName("Role name")]
        public string RoleName { get; set; }
        [DisplayName("Role description")]
        public string RoleDescription { get; set; }

        public static implicit operator EmployeeDetailsViewModel(Employee employee)
        {
            return new EmployeeDetailsViewModel
            {
                AnualSalary = employee.AnualSalary.ToString("C"),
                ContractTypeName = employee.ContractType == Service.Enum.ContractType.HourlySalaryEmployee ? "Hourly salary" : "Monthly salary",
                Id = employee.Id,
                Name = employee.Name,
                RoleName = employee.Role.Name,
                RoleDescription = employee.Role.Description
            };
        }
    }
}