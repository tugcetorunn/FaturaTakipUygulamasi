using FaturaTakipUygulamasi.Abstracts;
using FaturaTakipUygulamasi.Data;
using Microsoft.EntityFrameworkCore;

namespace FaturaTakipUygulamasi.Repositories
{
    /// <summary>
    /// IRepository<T> interface ini implement eden ve tüm entityler için ortak olan metodları içeren sınıf. contexti sadece burada çağırıyoruz. controllerda da repository metodları sayesşnde sadece bu metodların çağrılması yeterli oluyor. 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly FaturaDbContext context; // türeyen sınıfların bu field ları kullanabilmeleri için protected olarak tanımlanıyor.
        protected readonly DbSet<TEntity> table;

        public BaseRepository(FaturaDbContext _context)
        {
            context = _context;
            table = context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> ListeleAsync()
        {
            return await table.ToListAsync();
        }

        public async Task<TEntity> BulAsync(int id)
        {
            return await table.FindAsync(id);
        }

        public async Task EkleAsync(TEntity entity)
        {
            await table.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task GuncelleAsync(TEntity entity)
        {
            table.Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task SilAsync(int id)
        {
            var entity = await BulAsync(id);
            if (entity != null)
            {
                table.Remove(entity);
                await context.SaveChangesAsync();
            }
        }
    }
}
