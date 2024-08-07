using Microsoft.AspNetCore.Mvc;
using Services;
using ServiceContracts;

namespace LayoutViewExample.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ICitiesService _cityService;
        private readonly ISalaryService _salaryService;
        private readonly IServiceScopeFactory _scopeFactory;

        //Constructor
        public EmployeeController(ICitiesService citiesService, ISalaryService salaryService, IServiceScopeFactory scopeFactory)
        {
            _cityService = citiesService;
            _salaryService = salaryService;
            _scopeFactory = scopeFactory;
            //object of Service classes 
            //_cityService = new CitiesService();
            //_salaryService = new SalaryService();
        }

        [Route("employee")]
        public IActionResult Index()
        {
            return View();
        }
      
        [Route("employee/emp-detail")]
        public IActionResult EmpDetails()
        {
            List<int> salaries = _salaryService.GetSalaries();
            ViewBag.Instance_SalaryId = _salaryService.GetId();
            return View(salaries);
        }

        [HttpGet("employee/dept-detail")]
        public IActionResult DeptDetails()
        {
            List<string> cities = _cityService.GetCities(); 

            using (IServiceScope scope = _scopeFactory.CreateScope())
            {
                scope.ServiceProvider.GetService<ISalaryService>();
            } // end of scope it calls dispose method 
            return View(cities);
        }
        [HttpPost("employee/dept-detail")]
        public IActionResult Dept()
        {
            List<string> cities = _cityService.GetCities();
            return View("DeptDetails", cities);
        }
    }
}
