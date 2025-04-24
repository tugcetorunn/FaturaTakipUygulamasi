using FaturaTakipUygulamasi.Abstracts;
using FaturaTakipUygulamasi.ViewModels.Faturalar;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FaturaTakipUygulamasi.Controllers
{
    /// <summary>
    /// fatura ile ilgili crud metodlarının çalıştırılacağı kullanıcıdan veri alınıp işleneceği controller
    /// </summary>
    [Authorize] // sadece giriş yapmış kullanıcıların erişebileceği controller
    public class FaturaController : Controller
    {
        private readonly IFaturaRepository faturaRepository;
        public FaturaController(IFaturaRepository _faturaRepository)
        {
            faturaRepository = _faturaRepository;
        }
        public async Task<IActionResult> Listele()
        {
            var faturalar = await faturaRepository.IliskiliListeleAsync();
            return View(faturalar);
        }

        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Ekle(FaturaEkleVM fatura)
        {
            if (ModelState.IsValid)
            {
                await faturaRepository.EkleAsync(fatura);
                return RedirectToAction("Listele");
            }
            return View(fatura);
        }
    }
}
