using _07_CodeFirstDoktor.DAL.Interfaces;
using _07_CodeFirstDoktor.Models;
using _07_CodeFirstDoktor.Models.VMs;
using Microsoft.AspNetCore.Mvc;

namespace _07_CodeFirstDoktor.Controllers
{
    public class Doktor2Controller : Controller
    {
        private IDoktor _dRepo;

        //repolarla iş yapalım
        public Doktor2Controller(IDoktor dRepo)
        {
            _dRepo = dRepo;
        }

        //tüm doktorları gösterdiğim yer
        public IActionResult Listele()
        {
            return View(_dRepo.TumDoktorlariGetir());
        }

        public IActionResult Ekle()
        {
            return View(new DoktorEkleVM());
        }

        [HttpPost]
        public IActionResult Ekle(DoktorEkleVM vm)
        {
            TempData["sonuc"] = _dRepo.Ekle(vm) ? "Ekleme işlemi başarılı" : "Ekleme işlemi başarısız";
            return RedirectToAction(nameof(Listele));
        }

        public IActionResult Guncelle(int id)
        {
            //toDo: nasıl daha iyi olur
            Doktor doktor = _dRepo.DoktorGetir(id);
            DoktorGuncelleVM vm = new DoktorGuncelleVM()
            {
                Id = doktor.Id,
                Isim = doktor.Ad,
                Soyisim = doktor.Soyad,
                Brans = doktor.Brans,
                Mail = doktor.Email,
                DogumTarihi = doktor.DogumTarihi
            };
            return View();
        }

        [HttpPost]
        public IActionResult Guncelle(DoktorGuncelleVM vm)
        {
            TempData["sonuc"] = _dRepo.Guncelle(vm) ? "Güncelleme işlemi başarılı" : "Güncelleme işlemi başarısız";
            return RedirectToAction(nameof(Listele));
        }

        public IActionResult Sil(int id)
        {
            TempData["sonuc"] = _dRepo.Sil(id) ? "Silme işlemi başarılı" : "Silme işlemi başarısız";
            return RedirectToAction(nameof(Listele));
        }

        //toDo: Listeleme sayfasına bir buton ekleyin ve bu buton tüm doktorları branşlarına göre a-->z sıralı getirsin
    }
}