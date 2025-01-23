namespace _01_FirstWebProject.Models.SeedData
{
    public class Kisiler
    {
        public static List<Kisi> kisiListesi = new List<Kisi>()
        {
            new Kisi(){Id=1,Ad="Emir",Soyad="Cihan",DogumTarihi=new DateTime(2001,09,28)},
            new Kisi(){Id=2,Ad="Serra",Soyad="Cihan",DogumTarihi=new DateTime(2001,08,08)},
            new Kisi(){Id=3,Ad="Serra",Soyad="Şenocak",DogumTarihi=new DateTime(2001,08,09)},
            new Kisi(){Id=4,Ad="Sercan",Soyad="Çelik",DogumTarihi=new DateTime(2000,2,01)},
            new Kisi(){Id=5,Ad="Metin",Soyad="Mutlu",DogumTarihi=new DateTime(2001,02,02)},
            new Kisi(){Id=6,Ad="Erdal",Soyad="Saygi",DogumTarihi=new DateTime(2001,01,06)}
        };
    }
}