using SalaryCalculator.Repository.Interface;
using SalaryCalculator.Repository.Service;
using SalaryCalculator.Service.CalculatorFactory;
using SalaryCalculator.Service.CalculatorFactory.Interface;
using SalaryCalculator.Service.Interface;
using SalaryCalculator.Service.Service;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SalaryCalculator.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = new Container();
            container.Register<IEmployeeRepository, EmployeeRepository>();
            container.Register<IEmployeeService, EmployeeService>();
            container.Register<ICalculatorFactory, CalculatorFactory>();

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}
