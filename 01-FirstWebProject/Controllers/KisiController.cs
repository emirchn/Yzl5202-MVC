using _01_FirstWebProject.Models;
using _01_FirstWebProject.Models.SeedData;
using Microsoft.AspNetCore.Mvc;

namespace _01_FirstWebProject.Controllers
{
    //id,ad,soyad,doğum tarihi propları olan kisi sınıfı oluşturun
    //kişilerimizi barındıran statik bir list yapısı oluşturalım başka bir sınıf içinde
    public class KisiController : Controller
    {
        public IActionResult KisiyiGetir()
        {
            Kisi kisi = Kisiler.kisiListesi.LastOrDefault();
            return View(kisi);
        }

        public IActionResult Index()
        {
            //açılış sayfası
            //sahip olduğum tüm kişileri listeleyelim ve tabloya basalım
            return View("KisiIndex", Kisiler.kisiListesi);
        }

        public IActionResult KisiListele()
        {
            return View("KisiListele", Kisiler.kisiListesi);
        }
    }
}