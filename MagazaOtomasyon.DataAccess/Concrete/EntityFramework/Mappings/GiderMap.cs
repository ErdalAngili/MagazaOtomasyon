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
    public class GiderMap:EntityTypeConfiguration<Gider>
    {
        public GiderMap()
        {
            HasKey(p => p.GiderId);
            Property(p => p.GiderId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Ay).HasMaxLength(10);
            Property(p => p.Yil).HasMaxLength(10);
            Property(p => p.Elektrik).HasPrecision(18, 2);
            Property(p => p.Su).HasPrecision(18, 2);
            Property(p => p.Dogalgaz).HasPrecision(18, 2);
            Property(p => p.Internet).HasPrecision(18, 2);
            Property(p => p.Maaslar).HasPrecision(18, 2);
            Property(p => p.Ekstra).HasPrecision(18, 2);
            Property(p => p.Notlar).HasMaxLength(250);
        }
    }
}
