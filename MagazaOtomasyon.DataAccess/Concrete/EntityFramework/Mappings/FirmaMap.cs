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
    public class FirmaMap:EntityTypeConfiguration<Firma>
    {
        public FirmaMap()
        {
            HasKey(p => p.FirmaId);
            Property(p => p.FirmaId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.FirmaAd).HasMaxLength(30);
            Property(p => p.YetkiliStatu).HasMaxLength(30);
            Property(p => p.YetkiliAdSoyad).HasMaxLength(35);
            Property(p => p.Sektor).HasMaxLength(30);
            Property(p => p.Telefon1).HasMaxLength(15);
            Property(p => p.Telefon2).HasMaxLength(15);
            Property(p => p.Mail).HasMaxLength(40);
            Property(p => p.Fax).HasMaxLength(15);
            Property(p => p.Il).HasMaxLength(13);
            Property(p => p.Ilce).HasMaxLength(20);
            Property(p => p.VergiDaire).HasMaxLength(30);
            Property(p => p.Adres).HasMaxLength(100);
            Property(p => p.OzelKod1).HasMaxLength(10);
            Property(p => p.OzelKod2).HasMaxLength(10);
        }
    }
}
