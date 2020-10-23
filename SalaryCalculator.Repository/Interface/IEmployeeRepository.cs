using SalaryCalculator.Repository.Model;
using System.Collections.Generic;

namespace SalaryCalculator.Repository.Interface
{
    public interface IEmployeeRepository
    {
        List<Employee> Get();
    }
}
