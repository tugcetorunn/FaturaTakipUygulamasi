using FaturaTakipUygulamasi.Abstracts;
using FaturaTakipUygulamasi.Data;
using FaturaTakipUygulamasi.Models;

namespace FaturaTakipUygulamasi.Repositories
{
    /// <summary>
    /// ürünler için interfaceten gelen metodları gerçekleştirecek olan repository
    /// </summary>
    public class UrunRepository : BaseRepository<Urun>, IUrunRepository
    {
        public UrunRepository(FaturaDbContext context) : base(context)
        {
        }

    }
}
