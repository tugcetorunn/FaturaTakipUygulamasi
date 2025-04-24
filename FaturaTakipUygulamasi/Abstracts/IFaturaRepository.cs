using FaturaTakipUygulamasi.Models;
using FaturaTakipUygulamasi.ViewModels.Faturalar;

namespace FaturaTakipUygulamasi.Abstracts
{
    public interface IFaturaRepository : IRepository<Fatura>
    {
        // Faturalara özel metodlar eklenebilir.
        Task<IEnumerable<FaturaListeleVM>> IliskiliListeleAsync(); // base repository generic olduğu için include metodu ile listele metodu çalıştıramayız. Bu yüzden burada iliskili listeleme metodu tanımlıyoruz. Bu metod fatura, müşteri, ürün tablosunu birleştirip listeleyecek.
        Task<FaturaDetayVM> IliskiliBulAsync(int id);
        Task IliskiliEkleAsync(FaturaEkleVM fatura); 
    }
}
