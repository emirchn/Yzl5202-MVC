using _05_Template.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05_Template.Controllers
{
    public class MobilyaController : Controller
    {
        public static List<Mobilya> mobilyalar = new List<Mobilya>()
        {
            new Mobilya() {Id=1,Ad="Kanepe",Fiyat=3000,Stok=600,HamMadde="Meşe",UreticiAd="Enza",Aciklama="Meşeden üretilmiş sağlam kanepe"},
            new Mobilya() {Id=2,Ad="Koltuk Takımı",Fiyat=8000,Stok=600,HamMadde="Ahşap",UreticiAd="Vivense",Aciklama="3lü koltuk takımı"},
            new Mobilya() {Id=3,Ad="Baza",Fiyat=1000,Stok=800,HamMadde="Meşe",UreticiAd="Bellona",Aciklama="sağlam baza"},
            new Mobilya() {Id=4,Ad="Baza başlığı",Fiyat=700,Stok=400,HamMadde="Gürgen",UreticiAd="Bellona",Aciklama="gürgen baza başlığı"},
            new Mobilya() {Id=5,Ad="Gardırop",Fiyat=26000,Stok=230,HamMadde="Sunta",UreticiAd="Çilek",Aciklama="Suntadan üretilmiş gardırop"}
        };

        public IActionResult Index()
        {
            return View(mobilyalar);
        }

        public IActionResult Detay(int id)
        {
            Mobilya mobilya = mobilyalar.SingleOrDefault(x => x.Id == id);
            return View(mobilya);
        }
    }
}