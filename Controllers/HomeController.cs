// Controllers/HomeController.cs
using age_mate_v2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace age_mate_v2.Controllers
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
            // Create an instance of AgeDetails with sample values
            AgeDetails ageDetails = new AgeDetails(25, 35);
            return View(ageDetails);
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