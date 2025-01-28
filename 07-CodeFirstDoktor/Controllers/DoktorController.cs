using _07_CodeFirstDoktor.DAL.Interfaces;
using _07_CodeFirstDoktor.Models;
using _07_CodeFirstDoktor.Models.VMs;
using Microsoft.AspNetCore.Mvc;

namespace _07_CodeFirstDoktor.Controllers
{
    public class DoktorController : Controller
    {
        private ProjeDbContext _db;

        public DoktorController(ProjeDbContext db)
        {
            _db = db;
        }

        //doktorların ana sayfası
        public IActionResult Index()
        {
            List<Doktor> doktorlarim = _db.Doktorlar.ToList();
            return View(doktorlarim);
        }

        //Doktor ekle
        public IActionResult DoktorEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DoktorEkle(Doktor doktor)
        {
            _db.Doktorlar.Add(doktor);
            if (_db.SaveChanges() > 0)
            {
                TempData["mesaj"] = "Doktor ekleme işlemi başarılı";
            }
            else
            {
                TempData["mesaj"] = "Doktor ekleme işlemi başarısız";
            }
            return RedirectToAction("Index");
        }

        public IActionResult Sil(int Id)
        {
            Doktor silinecekDoktor = _db.Doktorlar.SingleOrDefault(x => x.Id == Id);
            return View(silinecekDoktor);
        }

        [HttpPost]
        public IActionResult Sil(Doktor silinecekDoktor)
        {
            _db.Doktorlar.Remove(silinecekDoktor);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Guncelle(int Id)
        {
            Doktor guncellenecekDoktor = _db.Doktorlar.SingleOrDefault(x => x.Id == Id);
            return View(guncellenecekDoktor);
        }

        [HttpPost]
        public IActionResult Guncelle(Doktor guncellenecekDoktor)
        {
            Doktor eskiDoktor = _db.Doktorlar.SingleOrDefault(x => x.Id == guncellenecekDoktor.Id);
            eskiDoktor.Ad = guncellenecekDoktor.Ad;
            eskiDoktor.Soyad = guncellenecekDoktor.Soyad;
            eskiDoktor.DogumTarihi = guncellenecekDoktor.DogumTarihi;
            eskiDoktor.Email = guncellenecekDoktor.Email;
            eskiDoktor.Brans = guncellenecekDoktor.Brans;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}