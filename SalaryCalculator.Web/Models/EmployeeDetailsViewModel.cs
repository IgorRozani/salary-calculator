using System.ComponentModel;

namespace SalaryCalculator.Web.Models
{
    public class EmployeeDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayName("Anual salary")]
        public decimal AnualSalary { get; set; }
        [DisplayName("Contract Type")]
        public string ContractTypeName { get; set; }
        [DisplayName("Role name")]
        public string RoleName { get; set; }
        [DisplayName("Role description")]
        public string RoleDescription { get; set; }
    }
}