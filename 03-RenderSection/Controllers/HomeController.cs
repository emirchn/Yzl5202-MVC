using _03_RenderSection.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _03_RenderSection.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GirisSayfasi()
        {
            return View();
        }

        public IActionResult KayitSayfasi()
        {
            return View();
        }

        public IActionResult CikisSayfasi()
        {
            return View();
        }
    }
}