using _02_HttpGetPost.Models;

namespace _02_HttpGetPost.SeedData
{
    public class Personeller
    {
        public static List<Personel> personelListesi = new List<Personel>()
        {
            new Personel(){ Mail="emir@gmail.com", Sifre="1234"},
            new Personel(){ Mail="serra@gmail.com", Sifre="2345"},
            new Personel(){ Mail="elif@gmail.com", Sifre="3456"}
        };
    }
}