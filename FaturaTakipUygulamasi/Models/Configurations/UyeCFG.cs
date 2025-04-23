using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FaturaTakipUygulamasi.Models.Configurations
{
    /// <summary>
    /// üyenin database yapılandırmasını yapar. db model oluşurken ilk eklenecek dataları hazırlar.
    /// </summary>
    public class UyeCFG : IEntityTypeConfiguration<Uye>
    {
        public void Configure(EntityTypeBuilder<Uye> builder)
        {
            builder.Property(x => x.Ad).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Soyad).IsRequired().HasMaxLength(50);
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);

            Uye admin = new Uye
            {
                Id = Guid.NewGuid().ToString(),
                Ad = "Ahmet",
                Soyad = "Yılmaz",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMİN@MAİL.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

            PasswordHasher<Uye> passwordHasher = new PasswordHasher<Uye>();
            admin.PasswordHash = passwordHasher.HashPassword(admin, "123Admin*");
            builder.HasData(admin);
        }
    }
}
