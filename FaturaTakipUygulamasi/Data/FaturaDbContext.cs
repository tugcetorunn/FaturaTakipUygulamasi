using FaturaTakipUygulamasi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FaturaTakipUygulamasi.Data
{
    /// <summary>
    /// database in oluşması için gerekli olan DbContext sınıfı
    /// </summary>
    public class FaturaDbContext : IdentityDbContext<Uye>
    {
        public FaturaDbContext()
        {
            
        }
        public FaturaDbContext(DbContextOptions<FaturaDbContext> options) : base(options)
        {
        }

        public DbSet<Fatura> Faturalar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<FaturaUrun> FaturaUrun { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
