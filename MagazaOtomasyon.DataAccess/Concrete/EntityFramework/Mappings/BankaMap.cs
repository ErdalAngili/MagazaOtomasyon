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
    public class BankaMap:EntityTypeConfiguration<Banka>
    {
        public BankaMap()
        {
            HasKey(p => p.BankaId);
            Property(p => p.BankaId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.BankaAdı).HasMaxLength(30);
            Property(p => p.Il).HasMaxLength(13);
            Property(p => p.Ilce).HasMaxLength(20);
            Property(p => p.Sube).HasMaxLength(30);
            Property(p => p.Iban).HasMaxLength(30);
            Property(p => p.HesapNo).HasMaxLength(20);
            Property(p => p.Yetkili).HasMaxLength(30);
            Property(p => p.Telefon).HasMaxLength(15);
            Property(p => p.Tarih).HasMaxLength(10);
            Property(p => p.HesapTuru).HasMaxLength(20);
        }
    }
}
