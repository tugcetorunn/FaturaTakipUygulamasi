using System.ComponentModel.DataAnnotations;

namespace FaturaTakipUygulamasi.ViewModels.Faturalar
{
    /// <summary>
    /// fatura güncellenirken kullanıcıdan alınacak bilgileri tutan view model
    /// </summary>
    public class FaturaGuncellemeVM
    {
        [Display(Name = "Fatura No")]
        [Required(ErrorMessage = "Fatura No boş olamaz")]
        [StringLength(16, ErrorMessage = "Fatura No en fazla 16 karakter olmalıdır")]
        public string FaturaNo { get; set; }

        [Display(Name = "Açıklama")]
        [StringLength(100, ErrorMessage = "Açıklama en fazla 100 karakter olmalıdır")]
        [Required(ErrorMessage = "Açıklama boş olamaz")]
        public string Aciklama { get; set; }

        public int MusteriId { get; set; }
        public ICollection<int> UrunIdler { get; set; } // seçilen ürünlerin id'lerini tutar
    }
}