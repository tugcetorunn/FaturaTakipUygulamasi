namespace FaturaTakipUygulamasi.Abstracts
{
    /// <summary>
    /// tüm entityler için ortak olan metodları bir kere yazıp diğer repositorylerde kullanabilmek için oluşturuldu. interface repo ile class repo katmanlıda farklı projelerde yer aldığı için ayrı dosyalarda oluşturuldu.
    /// </summary>
    /// <typeparam name="TEntity"> generic olması için </typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> ListeleAsync();
        Task<TEntity> BulAsync(int id);
        Task EkleAsync(TEntity entity);
        Task GuncelleAsync(TEntity entity);
        Task SilAsync(int id);
    }
}
