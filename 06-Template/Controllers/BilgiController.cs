using Microsoft.AspNetCore.Mvc;

namespace _06_Template.Controllers
{
    public class BilgiController : Controller
    {
        public IActionResult Doktorlar()
        {
            return View();
        }

        public IActionResult Detay()
        {
            return View();
        }

        public IActionResult Randevu()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public IActionResult Arama()
        {
            return View();
        }
    }
}