using SalaryCalculator.Service.Model;
using System.ComponentModel;

namespace SalaryCalculator.Web.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayName("Anual salary")]
        public decimal AnualSalary { get; set; }

        public static implicit operator EmployeeViewModel(Employee employee)
        {
            return new EmployeeViewModel
            {
                AnualSalary = employee.AnualSalary,
                Id = employee.Id,
                Name = employee.Name
            };
        }
    }
}