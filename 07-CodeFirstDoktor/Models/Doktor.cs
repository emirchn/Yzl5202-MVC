using System.ComponentModel.DataAnnotations;

namespace _07_CodeFirstDoktor.Models
{
    public class Doktor
    {
        public int Id { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Email { get; set; }

        public string Brans { get; set; }
    }
}