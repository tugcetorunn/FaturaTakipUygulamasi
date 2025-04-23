namespace FaturaTakipUygulamasi.Models
{
    /// <summary>
    /// Ürün için database modelini temsil eder.
    /// </summary>
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyati { get; set; }
        public int StokMiktari { get; set; }
        public ICollection<FaturaUrun>? FaturaUrun { get; set; } // çoka çok ilişki
    }
}
