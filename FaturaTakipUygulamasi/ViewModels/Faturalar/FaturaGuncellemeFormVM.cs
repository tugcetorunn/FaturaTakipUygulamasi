using Microsoft.AspNetCore.Mvc.Rendering;

namespace FaturaTakipUygulamasi.ViewModels.Faturalar
{
    /// <summary>
    /// Fatura güncelleme formunda kullanılacak view model
    /// </summary>
    public class FaturaGuncellemeFormVM
    {
        public SelectList Musteriler { get; set; } // Müşteri listesini tutar
        public SelectList Urunler { get; set; } // Ürün listesini tutar
        public FaturaGuncellemeVM Fatura { get; set; } // Kullanıcıdan alınacak fatura bilgilerini tutar
    }
}
