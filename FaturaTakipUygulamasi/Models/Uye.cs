using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace FaturaTakipUygulamasi.Models
{
    /// <summary>
    /// kullanıcı için database modelini temsil eder.
    /// </summary>
    public class Uye : IdentityUser
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        [NotMapped]
        public string AdSoyad => $"{Ad} {Soyad}"; // önyüzde gösterim için
    }
}
