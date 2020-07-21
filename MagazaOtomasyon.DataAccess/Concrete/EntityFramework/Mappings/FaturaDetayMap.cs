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
    public class FaturaDetayMap:EntityTypeConfiguration<FaturaDetay>
    {
        public FaturaDetayMap()
        {
            HasKey(p => p.FaturaUrunId);
            Property(p => p.FaturaUrunId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.UrunAd).HasMaxLength(20);
            Property(p => p.Fiyat).HasPrecision(18, 2);
            Property(p => p.Tutar).HasPrecision(18, 2);
        }
    }
}
