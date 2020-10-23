using SalaryCalculator.Repository.Service;
using Xunit;

namespace SalaryCalculator.Test.Repository
{
    public class EmployeeRepositoryTest
    {
        private EmployeeRepository _employeeDAL;

        public EmployeeRepositoryTest()
        {
            _employeeDAL = new EmployeeRepository();
        }

        [Fact]
        public void Get()
        {
            var result = _employeeDAL.Get();

            Assert.NotEmpty(result);
        }
    }
}
