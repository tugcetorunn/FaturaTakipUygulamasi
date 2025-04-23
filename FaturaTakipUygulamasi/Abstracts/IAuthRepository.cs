using FaturaTakipUygulamasi.Models;
using FaturaTakipUygulamasi.ViewModels.Auth;

namespace FaturaTakipUygulamasi.Abstracts
{
    /// <summary>
    /// kullanıcı giriş işlemleri için gerekli olan metodları içeren interface
    /// </summary>
    public interface IAuthRepository
    {
        Task<Uye> Login(LoginVM login);
        Task Register(RegisterVM register);
    }
}
