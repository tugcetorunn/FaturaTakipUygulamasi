using AutoMapper;
using FaturaTakipUygulamasi.Abstracts;
using FaturaTakipUygulamasi.Data;
using FaturaTakipUygulamasi.Models;
using FaturaTakipUygulamasi.ViewModels.Auth;
using Microsoft.AspNetCore.Identity;

namespace FaturaTakipUygulamasi.Repositories
{
    /// <summary>
    /// kullanıcı giriş işlemleri için implement edilen interface teki metodların doldurulduğu class
    /// </summary>
    public class AuthRepository : IAuthRepository
    {
        private readonly UserManager<Uye> userManager; // identity kütüphanesine ait kullanıcı işlemleri için gerekli class
        // bu repository nin platform bağımsız (masaüstü, mobil vs) çalışabilmesi için signin manager ı burada kullanmıyoruz. çünkü oluşturduğu bilgileri session üzeerinde saklıyor. controller da kullanacağız.
        private readonly IMapper mapper; // map metodunu kullanabilmek için gerekli olan mapper nesnesi
        public AuthRepository(UserManager<Uye> _userManager, IMapper _mapper)
        {
            userManager = _userManager;
            mapper = _mapper;
        }
        public async Task<Uye> Login(LoginVM login)
        {
            var uye = await userManager.FindByNameAsync(login.Username); // kullanıcı adı ile önce kullanıcı var mı diye bakıyoruz
            if(uye != null) // kullanıcı varsa
            {
                var result = await userManager.CheckPasswordAsync(uye, login.Password); // şifre kontrolü yapıyoruz
                if (result) // şifre doğruysa
                {
                    return uye;
                }
            }

            return null; // kullanıcı yoksa veya şifre yanlışsa null döner
        }

        public async Task Register(RegisterVM register)
        {
            var uye = mapper.Map<Uye>(register); // register viewmodelini entityye dönüştürüyoruz
            var result = await userManager.CreateAsync(uye, register.Password); // kullanıcıyı oluşturuyoruz
        }
    }
}
