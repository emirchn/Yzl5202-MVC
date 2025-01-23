using _01_FirstWebProject.Models;
using _01_FirstWebProject.Models.SeedData;
using Microsoft.AspNetCore.Mvc;

namespace _01_FirstWebProject.Controllers
{
    public class PersonController : Controller
    {
        //index viewda her kili için bir card basalım
        //card-text bilgisindeki kişinin id age ad soyad kullanarak bir cümmle oluşturalım
        // cardın içindeki butonu kişinin araba sayısınca arabasının adını basalım
        public IActionResult Index()
        {
            return View(Galeri.people);
        }
    }
}