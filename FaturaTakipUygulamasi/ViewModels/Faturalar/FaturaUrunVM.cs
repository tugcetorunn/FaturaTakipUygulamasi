using System.ComponentModel.DataAnnotations;

namespace FaturaTakipUygulamasi.ViewModels.Faturalar
{
    /// <summary>
    /// Bu viewmodeli kullanarak fatura ürünlerini listeleyeceğiz.
    /// </summary>
    public class FaturaUrunVM
    {
        [Display(Name = "Ürün Adı")]
        public string UrunAdi { get; set; }
    }
}