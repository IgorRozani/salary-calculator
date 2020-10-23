using SalaryCalculator.Service.Model;
using System.Collections.Generic;

namespace SalaryCalculator.Service.Interface
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();

        Employee Get(int id);
    }
}
