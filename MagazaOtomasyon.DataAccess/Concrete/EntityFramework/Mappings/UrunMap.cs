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
    public class UrunMap:EntityTypeConfiguration<Urun>
    {
        public UrunMap()
        {
            HasKey(p => p.UrunId);
            Property(p => p.UrunId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.UrunAd).HasMaxLength(30);
            Property(p => p.Marka).HasMaxLength(20);
            Property(p => p.Model).HasMaxLength(20);
            Property(p => p.Maliyet).HasPrecision(18, 2);
            Property(p => p.SatisFiyat).HasPrecision(18, 2);
            Property(p => p.Detay).HasMaxLength(250);
        }
    }
}
