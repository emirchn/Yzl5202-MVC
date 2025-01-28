using _07_CodeFirstDoktor.Models;
using _07_CodeFirstDoktor.Models.VMs;

namespace _07_CodeFirstDoktor.DAL.Interfaces
{
    public interface IDoktor
    {
        bool Ekle(DoktorEkleVM vm);

        bool Sil(int Id);

        bool Guncelle(DoktorGuncelleVM vm);

        List<Doktor> TumDoktorlariGetir();

        Doktor DoktorGetir(int Id);
    }
}