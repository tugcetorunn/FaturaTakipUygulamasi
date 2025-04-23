using System.ComponentModel.DataAnnotations.Schema;

namespace FaturaTakipUygulamasi.Models
{
    /// <summary>
    /// Müşteri için database modelini temsil eder.
    /// </summary>
    public class Musteri
    {
        public int MusteriId { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        [NotMapped]
        public string AdSoyad => $"{MusteriAdi} {MusteriSoyadi}"; // önyüzde gösterim için
        public string VergiNo { get; set; }
        public string VergiDairesi { get; set; }
        public string Telefon { get; set; }
        public ICollection<Fatura>? Faturalar { get; set; } // bire çok ilişki
    }
}