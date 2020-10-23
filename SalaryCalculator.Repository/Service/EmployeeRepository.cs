using Flurl.Http;
using SalaryCalculator.Repository.Interface;
using SalaryCalculator.Repository.Model;
using System.Collections.Generic;
using System.Configuration;

namespace SalaryCalculator.Repository.Service
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> Get()
        {
            var api = ConfigurationManager.AppSettings["EmployeeApi"];

            var response = api.GetJsonAsync<List<Employee>>();

            response.Wait();

            return response.Result;
        }
    }
}
