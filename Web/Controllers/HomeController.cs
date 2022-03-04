using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Models;
using ConsoleAppProject.App02;
using ConsoleAppProject.App01;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DistanceConverter(DistanceConverter converter)
        {
            if (converter.FromDistance > 0)
            {
                converter.CalculateDistance();
            }
            return View(converter);
        }
    
        public IActionResult BmiCalculator()
        {
            return View();
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