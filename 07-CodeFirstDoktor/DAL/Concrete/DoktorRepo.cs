using _07_CodeFirstDoktor.DAL.Interfaces;
using _07_CodeFirstDoktor.Models;
using _07_CodeFirstDoktor.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace _07_CodeFirstDoktor.DAL.Concrete
{
    public class DoktorRepo : IDoktor
    {
        public DoktorRepo(ProjeDbContext db)
        {
            _db = db;
        }

        private ProjeDbContext _db;

        public bool Ekle(DoktorEkleVM vm)
        {
            _db.Doktorlar.Add(new Doktor()
            {
                Ad = vm.Isim,
                Soyad = vm.Soyisim,
                Brans = vm.Brans,
                Email = vm.Mail,
                DogumTarihi = vm.DogumTarihi
            });
            return _db.SaveChanges() > 0;
        }

        public bool Guncelle(DoktorGuncelleVM vm)
        {
            Doktor doktor = _db.Doktorlar.SingleOrDefault(x => x.Id == vm.Id);
            doktor.Ad = vm.Isim;
            doktor.Soyad = vm.Soyisim;
            doktor.Brans = vm.Brans;
            doktor.Email = vm.Mail;
            doktor.DogumTarihi = vm.DogumTarihi;
            _db.Doktorlar.Update(doktor);
            return _db.SaveChanges() > 0;
        }

        public bool Sil(int Id)
        {
            _db.Doktorlar.Remove(_db.Doktorlar.SingleOrDefault(x => x.Id == Id));
            return _db.SaveChanges() > 0;
        }

        public List<Doktor> TumDoktorlariGetir()
        {
            return _db.Doktorlar.ToList();
        }

        public Doktor DoktorGetir(int Id)
        {
            return _db.Doktorlar.SingleOrDefault(x => x.Id == Id);
        }
    }
}