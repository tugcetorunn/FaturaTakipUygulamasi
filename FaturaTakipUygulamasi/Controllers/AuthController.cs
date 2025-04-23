using FaturaTakipUygulamasi.Abstracts;
using FaturaTakipUygulamasi.Models;
using FaturaTakipUygulamasi.ViewModels.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FaturaTakipUygulamasi.Controllers
{
    /// <summary>
    /// Kullanıcı giriş çıkış kayıt işlemleri için gerekli olan controller
    /// </summary>
    public class AuthController : Controller
    {
        private readonly IAuthRepository authRepository;
        private readonly SignInManager<Uye> signInManager;
        public AuthController(IAuthRepository _authRepository, SignInManager<Uye> _signInManager)
        {
            authRepository = _authRepository;
            signInManager = _signInManager;
        }
        public IActionResult Login() // login ekranı gösterme action
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM login) // login işlemi için post action
        {
            if (ModelState.IsValid)
            {
                var user = await authRepository.Login(login); // repositorydeki login metodunu çağırıyoruz.
                if (user != null) // eğer kullanıcı null değilse yani giriş başarılı ise kullanıcıya oturum açtırıyoruz. ispersistent oturumun kalıcı olup olmayacağını belirliyor. false ise browser kapandığında oturum kapanır.
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Listele", "Fatura");
                }
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı.");
            }
            ModelState.AddModelError("", "Girdiğiniz bilgiler geçersiz.");
            return View(login);
        }

        public IActionResult Register() // kayıt ekranı gösterme action
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM register) // kayıt işlemi için post action
        {
            if (ModelState.IsValid)
            {
                await authRepository.Register(register);
                return RedirectToAction("Login");
            }
            ModelState.AddModelError("", "Kayıt işlemi başarısız.");
            return View(register);
        }

        public async Task<IActionResult> Logout() // view e gerek yok
        {
            await signInManager.SignOutAsync(); // çıkış işlemi için signInManager sınıfını kullanıyoruz.
            return RedirectToAction("Login");
        }
    }
}
