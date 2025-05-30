﻿using System.ComponentModel.DataAnnotations;

namespace FaturaTakipUygulamasi.ViewModels.Faturalar
{
    /// <summary>
    /// fatura listeleme ekranında görğnecek alanları temsil eder.
    /// </summary>
    public class FaturaListeleVM
    {
        [Display(Name = "Fatura Sıra No")]
        public int FaturaId { get; set; } // listeleme ekranındaki düzenleme ve silme işlemleri için gerekli

        [Display(Name = "Fatura No")]
        public string FaturaNo { get; set; }

        [Display(Name = "Fatura Tarihi")]
        [DataType(DataType.Date)]
        public DateTime FaturaTarihi { get; set; }

        [Display(Name = "Toplam Tutar")]
        public decimal ToplamTutar { get; set; }

        [Display(Name = "Müşteri")]
        public string Musteri { get; set; } // müşteri adı gösterileceği için string olarak tanımlandı.
        
    }
}
