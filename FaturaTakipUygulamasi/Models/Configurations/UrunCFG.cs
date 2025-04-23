using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FaturaTakipUygulamasi.Models.Configurations
{
    /// <summary>
    /// ürün modelinin database yapılandırmasını yapar. db model oluşurken ilk eklenecek dataları hazırlar.
    /// </summary>
    public class UrunCFG : IEntityTypeConfiguration<Urun>
    {
        public void Configure(EntityTypeBuilder<Urun> builder)
        {
            builder.Property(x => x.UrunAdi).IsRequired().HasMaxLength(50);
            builder.Property(x => x.BirimFiyati).HasColumnType("money");

            // Varsayılan ürünler
            builder.HasData(new Urun
            {
                UrunId = 1,
                BirimFiyati = 25,
                UrunAdi = "Mavi tükenmez kalem",
                StokMiktari = 100
            },
            new Urun
            {
                UrunId = 2,
                BirimFiyati = 57,
                UrunAdi = "A4 boyutunda defter",
                StokMiktari = 50
            },
            new Urun
            {
                UrunId = 3,
                BirimFiyati = 5100,
                UrunAdi = "Bluetooth kulaklık",
                StokMiktari = 25
            });
        }
    }
}
