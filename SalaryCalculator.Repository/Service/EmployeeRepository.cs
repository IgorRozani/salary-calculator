using Flurl.Http;
using SalaryCalculator.Repository.Interface;
using SalaryCalculator.Repository.Model;
using System.Collections.Generic;

namespace SalaryCalculator.Repository.Service
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> Get()
        {
            var api = @"http://masglobaltestapi.azurewebsites.net/api/Employees";

            var response = api.GetJsonAsync<List<Employee>>();

            response.Wait();

            return response.Result;
        }
    }
}
