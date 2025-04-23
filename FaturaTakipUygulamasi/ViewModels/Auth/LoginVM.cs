using System.ComponentModel.DataAnnotations;

namespace FaturaTakipUygulamasi.ViewModels.Auth
{
    /// <summary>
    /// login ekranında kullanıcının göreceği alanları temsil eden view model
    /// </summary>
    public class LoginVM
    {
        [Required(ErrorMessage = "Kullanıcı adı boş olamaz")]
        [StringLength(50, ErrorMessage = "Kullanıcı adı en fazla 50 karakter olmalıdır")]
        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre boş olamaz")]
        [StringLength(50, ErrorMessage = "Şifre en fazla 50 karakter olmalıdır")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
    }
}
