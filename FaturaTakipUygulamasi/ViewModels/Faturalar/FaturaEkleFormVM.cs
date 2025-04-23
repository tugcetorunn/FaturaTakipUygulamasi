using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace FaturaTakipUygulamasi.ViewModels.Faturalar
{
    /// <summary>
    /// Fatura ekleme formunda kullanılacak view model
    /// </summary>
    public class FaturaEkleFormVM
    {
        public SelectList Musteriler { get; set; } // Müşteri listesini tutar
        public SelectList Urunler { get; set; } // Ürün listesini tutar
        public FaturaEkleVM Fatura { get; set; } // Kullanıcıdan alınacak fatura bilgilerini tutar

    }
}
