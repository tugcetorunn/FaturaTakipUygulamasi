namespace FaturaTakipUygulamasi.Models
{
    /// <summary>
    /// Fatura için database modelini temsil eder.
    /// </summary>
    public class Fatura
    {
        public int FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime FaturaTarihi { get; set; } = DateTime.Now; // varsayılan tarih oluşturulduğu andır.
        public string Aciklama { get; set; }
        public decimal ToplamTutar { get; set; }
        public int MusteriId { get; set; }
        public Musteri? Musteri { get; set; } // bire çok ilişki
        public ICollection<FaturaUrun>? FaturaUrun { get; set; } // çoka çok ilişki

    }
}
