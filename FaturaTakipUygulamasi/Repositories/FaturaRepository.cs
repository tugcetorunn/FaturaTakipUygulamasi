using AutoMapper;
using FaturaTakipUygulamasi.Abstracts;
using FaturaTakipUygulamasi.Data;
using FaturaTakipUygulamasi.Models;
using FaturaTakipUygulamasi.ViewModels.Faturalar;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace FaturaTakipUygulamasi.Repositories
{
    /// <summary>
    /// faturaya özel metodları içeren repository
    /// </summary>
    public class FaturaRepository : BaseRepository<Fatura>, IFaturaRepository // ortak metodlar için base den, kendi metodları için IFaturaRepository den miras alıyoruz. 
    {
        private readonly IMapper mapper; 
        public FaturaRepository(FaturaDbContext context, IMapper _mapper) : base(context) // costructor injection için base repo ya context i gönderiyoruz.
        {
            mapper = _mapper; // mapper nesnesi inject edildi.
        }

        public async Task<IEnumerable<FaturaListeleVM>> IliskiliListeleAsync()
        {
            var faturalar = await IncludeIleGetir() // include ile getirilmiş olan fatura listesini alıyoruz.
                .ToListAsync(); // listeleme işlemi yapıldı
            return mapper.Map<IEnumerable<FaturaListeleVM>>(faturalar); // mapper ile fatura listesini faturalistelevm e dönüştürüyoruz
        }

        public Task<FaturaDetayVM> IliskiliBulAsync(int id)
        {
            var fatura = IncludeIleGetir() 
                .FirstOrDefaultAsync(table => table.FaturaId == id);
        }

        public Task IliskiliEkleAsync(FaturaEkleVM fatura)
        {
            
        }

        public IQueryable<Fatura> IncludeIleGetir()
        {
            IQueryable<Fatura> iliskiliEntity = table.Include(table => table.Musteri) // müşteri tablosunu dahil edildi
                .Include(table => table.FaturaUrun); // ürün tablosunu dahil edildi
            return iliskiliEntity;
        }
    }
}
