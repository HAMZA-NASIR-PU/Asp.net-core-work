using FormUsingTagHelpers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FormUsingTagHelpers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(Employee e)
        {
            return "Name = " + e.Name + " Gender = " + e.Gender + " Age = " + e.Age + " Designation = " + e.Designation + " Salary = " + e.Salary + " Married = " + e.Married;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}