namespace FaturaTakipUygulamasi.Models
{
    /// <summary>
    /// Fatura ve ürün arasındaki çoka çok ilişkiyi temsil eder.
    /// </summary>
    public class FaturaUrun
    {
        public int FaturaId { get; set; }
        public int UrunId { get; set; }
        public decimal Tutar { get; set; } // ilgili faturadaki ürünün tutarı
        public int Miktar { get; set; } // ilgili faturadaki ürünün miktarı
        public Fatura? Fatura { get; set; } // çoka çok ilişki navigation property
        public Urun? Urun { get; set; } // çoka çok ilişki navigation property
    }
}