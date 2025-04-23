using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FaturaTakipUygulamasi.Models.Configurations
{
    /// <summary>
    /// Çokaçok ilişki tablosunun database yapılandırmasını yapar.
    /// </summary>
    public class FaturaUrunCFG : IEntityTypeConfiguration<FaturaUrun>
    {
        public void Configure(EntityTypeBuilder<FaturaUrun> builder)
        {
            builder.HasKey(x => new { x.FaturaId, x.UrunId }); // composite key
            builder.Property(x => x.Miktar).IsRequired();
            builder.Property(x => x.Tutar).HasColumnType("money").IsRequired();
        }
    }
}
