using _02_HttpGetPost.Models;
using _02_HttpGetPost.SeedData;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _02_HttpGetPost.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Bilgi = "Kişilerimiz ektedir.";
            TempData["info"] = "Kişiler";
            //tüm personelleri listele
            return View(Personeller.personelListesi);
        }

        public IActionResult Login()
        {
            //eğer kişi mail ve şifresini doğru girdiyse index sayfasına yönlensin ve viewbag ile başarı mesajı gösterilsin, bilgileri doğru giremediyse hata sayfasına yönlensin(home controllerda)
            return View();
        }

        [HttpPost]
        public IActionResult Login(Personel personel)
        {
            if (Personeller.personelListesi.FirstOrDefault(x => x.Mail == personel.Mail && x.Sifre == personel.Sifre) is not null)
            {
                ViewBag.MesajBilgi = "Giriş Başarılı";// oluşturulduğu actionun dışına çıkamaz
                TempData["Bildirim"] = "Giriş Başarılı";// kendi oluşturulduğu actionun viewı kullanılmazsa dışarı çıkar ama 1 kez iş yapar
                return RedirectToAction(nameof(Index));
            }
            else
                return RedirectToAction("Hata", "Home");
        }

        //yeni bir personel nesnesi oluşturalım, bilgilerini ondan alıp bizim statik listeye ekleyelim
        //fakat kayıt olurken şifresi en az 3 karakterli değilse ve mail adresi doğru formatta değilse ve boş geçilmediyse kişiyi oluşturup index sayfasına yönlendirelim ama en tepede alert ile bir başarı mesajı verelim
        //kayıt başarııl değilse yinede index sayfasına yönlenelim ama bu kez mesaj vs vermeyelim
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Personel personel)
        {
            string sifre = personel.Sifre;
            string mail = personel.Mail;
            if ((sifre.Length >= 3) && mail.Contains("@") && mail.Contains("."))
            {
                Personeller.personelListesi.Add(personel);
                TempData["basariMesaji"] = "Kayıt Başarılı";
                return RedirectToAction(nameof(Index));
            }
            else
                return RedirectToAction(nameof(Index));
        }
    }
}