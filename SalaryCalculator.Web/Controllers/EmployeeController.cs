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
                    employees.Add((EmployeeViewModel)employee);
            }
            else
                employees = _employeeService.GetAll().Select(e => (EmployeeViewModel)e).ToList();

            return View(employees);
        }

        public ActionResult Details(int id)
        {
            var employee = _employeeService.Get(id);

            if (employee == null)
                return RedirectToAction("Index");

            EmployeeDetailsViewModel employeeViewModel = employee;

            return View(employeeViewModel);
        }
    }
}