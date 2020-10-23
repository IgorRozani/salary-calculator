using System.ComponentModel;

namespace SalaryCalculator.Web.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayName("Anual salary")]
        public decimal AnualSalary { get; set; }
    }
}