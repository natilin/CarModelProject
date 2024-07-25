using CarModelProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarModelProject.Controllers
{
    public class CarController : Controller
    {
        private readonly ILogger<CarController> _logger;

        public CarController(ILogger<CarController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Model(string name, string year, string color)
        {
            Car car = new Car(name, year, color);
            return View(car);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
