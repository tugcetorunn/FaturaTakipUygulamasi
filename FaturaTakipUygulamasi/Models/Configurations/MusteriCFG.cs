using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FaturaTakipUygulamasi.Models.Configurations
{
    /// <summary>
    /// müşteri modelinin database yapılandırmasını yapar. db model oluşurken ilk eklenecek dataları hazırlar.
    /// </summary>
    public class MusteriCFG : IEntityTypeConfiguration<Musteri>
    {
        public void Configure(EntityTypeBuilder<Musteri> builder)
        {
            builder.Property(x => x.MusteriAdi).IsRequired().HasMaxLength(50);
            builder.Property(x => x.MusteriSoyadi).IsRequired().HasMaxLength(50);
            builder.Property(x => x.VergiNo).IsRequired().HasMaxLength(10);
            builder.Property(x => x.VergiDairesi).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Telefon).IsRequired().HasMaxLength(11);

            // Varsayılan müşteri verisi
            builder.HasData(new Musteri
            {
                MusteriId = 1,
                MusteriAdi = "Ali",
                MusteriSoyadi = "Veli",
                VergiNo = "1234567890",
                VergiDairesi = "İstanbul",
                Telefon = "05551234567"
            },
            new Musteri
            {
                MusteriId = 2,
                MusteriAdi = "Faruk",
                MusteriSoyadi = "Kılıç",
                VergiNo = "2234567890",
                VergiDairesi = "Bursa",
                Telefon = "05531234567"
            });
        }
    }
}
