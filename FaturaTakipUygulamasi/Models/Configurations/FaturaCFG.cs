using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FaturaTakipUygulamasi.Models.Configurations
{
    /// <summary>
    /// fatura modelinin database yapılandırmasını yapar.
    /// </summary>
    public class FaturaCFG : IEntityTypeConfiguration<Fatura>
    {
        public void Configure(EntityTypeBuilder<Fatura> builder)
        {
            builder.Property(f => f.FaturaNo).IsRequired().HasMaxLength(16);
            builder.Property(f => f.Aciklama).HasMaxLength(100);
            builder.Property(f => f.ToplamTutar).HasColumnType("money");
        }
    }
}
