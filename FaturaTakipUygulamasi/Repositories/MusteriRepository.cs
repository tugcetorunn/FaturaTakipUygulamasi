using FaturaTakipUygulamasi.Abstracts;
using FaturaTakipUygulamasi.Data;
using FaturaTakipUygulamasi.Models;

namespace FaturaTakipUygulamasi.Repositories
{
    /// <summary>
    /// müşteriye özel metodların oluşturulacağı repository
    /// </summary>
    public class MusteriRepository : BaseRepository<Musteri>, IMusteriRepository
    {
        public MusteriRepository(FaturaDbContext context) : base(context)
        {
        }

    }
}
