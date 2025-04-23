using System.ComponentModel.DataAnnotations;

namespace FaturaTakipUygulamasi.ViewModels.Auth
{
    /// <summary>
    /// register ekranında kullanıcının göreceği alanları temsil eden view model
    /// </summary>
    public class RegisterVM
    {
        [Required(ErrorMessage = "Kullanıcı adı boş olamaz")]
        [StringLength(50, ErrorMessage = "Kullanıcı adı en fazla 50 karakter olmalıdır")]
        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre boş olamaz")]
        [StringLength(50, ErrorMessage = "Şifre en fazla 50 karakter olmalıdır")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrarı boş olamaz")]
        [StringLength(50, ErrorMessage = "Şifre tekrarı en fazla 50 karakter olmalıdır")]
        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor")]
        [Display(Name = "Şifre Tekrar")]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage = "Ad boş olamaz")]
        [StringLength(50, ErrorMessage = "Ad en fazla 50 karakter olmalıdır")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Soyad boş olamaz")]
        [StringLength(50, ErrorMessage = "Soyad en fazla 50 karakter olmalıdır")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "E-posta boş olamaz")]
        [StringLength(100, ErrorMessage = "E-posta en fazla 100 karakter olmalıdır")]
        [EmailAddress(ErrorMessage = "Geçersiz e-posta adresi")]
        public string Email { get; set; }
    }
}
