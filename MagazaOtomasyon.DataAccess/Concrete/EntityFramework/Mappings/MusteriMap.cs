using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.DataAccess.Concrete.EntityFramework.Mappings
{
    public class MusteriMap:EntityTypeConfiguration<Musteri>
    {
        public MusteriMap()
        {
            HasKey(p => p.MusteriId);
            Property(p => p.MusteriId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Ad).HasMaxLength(20);
            Property(p => p.Soyad).HasMaxLength(30);
            Property(p => p.Telefon1).HasMaxLength(15);
            Property(p => p.Telefon2).HasMaxLength(15);
            Property(p => p.Mail).HasMaxLength(40);
            Property(p => p.Il).HasMaxLength(13);
            Property(p => p.Ilce).HasMaxLength(20);
            Property(p => p.Adres).HasMaxLength(100);
            Property(p => p.VergiDaire).HasMaxLength(30);
        }
    }
}
