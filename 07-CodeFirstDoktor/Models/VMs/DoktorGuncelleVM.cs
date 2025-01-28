namespace _07_CodeFirstDoktor.Models.VMs
{
    public class DoktorGuncelleVM
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }

        public DateTime DogumTarihi { get; set; }
        public string Mail { get; set; }
        public string Brans { get; set; }
    }
}