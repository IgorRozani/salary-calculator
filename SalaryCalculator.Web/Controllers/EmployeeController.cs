using SalaryCalculator.Service.Interface;
using SalaryCalculator.Service.Model;
using SalaryCalculator.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SalaryCalculator.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: Employee
        public ActionResult Index(int? id)
        {
            var employees = new List<EmployeeViewModel>();
            if (id.HasValue)
            {
                var employee = _employeeService.Get(id.Value);

                if (employee != null)
                    employees.Add(ConvertToViewModel(employee));
            }
            else
                employees = _employeeService.GetAll().Select(ConvertToViewModel).ToList();

            return View(employees);
        }

        public ActionResult Details(int id)
        {
            var employee = _employeeService.Get(id);

            if (employee == null)
                return RedirectToAction("Index");

            return View(ConvertToDetailsViewModel(employee));
        }

        private EmployeeViewModel ConvertToViewModel(Employee employee)
        {
            return new EmployeeViewModel
            {
                AnualSalary = employee.AnualSalary,
                Id = employee.Id,
                Name = employee.Name
            };
        }

        private EmployeeDetailsViewModel ConvertToDetailsViewModel(Employee employee)
        {
            return new EmployeeDetailsViewModel
            {
                AnualSalary = employee.AnualSalary,
                ContractTypeName = employee.ContractType == Service.Enum.ContractType.HourlySalaryEmployee ? "Hourly salary" : "Monthly salary",
                Id = employee.Id,
                Name = employee.Name,
                RoleName = employee.Role.Name,
                RoleDescription = employee.Role.Description
            };
        }
    }
}