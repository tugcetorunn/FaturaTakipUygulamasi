using FaturaTakipUygulamasi.Abstracts;
using FaturaTakipUygulamasi.Data;
using FaturaTakipUygulamasi.Models;

namespace FaturaTakipUygulamasi.Repositories
{
    /// <summary>
    /// faturaya özel metodları içeren repository
    /// </summary>
    public class FaturaRepository : BaseRepository<Fatura>, IFaturaRepository // ortak metodlar için base den, kendi metodları için IFaturaRepository den miras alıyoruz. 
    {
        public FaturaRepository(FaturaDbContext context) : base(context) // costructor injection için base repo ya context i gönderiyoruz.
        {
        }

    }
}
