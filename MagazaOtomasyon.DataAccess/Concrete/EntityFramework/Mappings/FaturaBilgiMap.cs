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
    public class FaturaBilgiMap:EntityTypeConfiguration<FaturaBilgi>
    {
        public FaturaBilgiMap()
        {
            HasKey(p => p.FaturaBilgiId);
            Property(p => p.FaturaBilgiId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.SiraNo).HasMaxLength(10);
            Property(p => p.Seri).HasMaxLength(5);
            Property(p => p.Tarih).HasMaxLength(10);
            Property(p => p.Saat).HasMaxLength(5);
            Property(p => p.VergiDaire).HasMaxLength(40);
            Property(p => p.Alici).HasMaxLength(30);
            Property(p => p.TeslimEden).HasMaxLength(30);
            Property(p => p.TeslimAlan).HasMaxLength(30);
        }
    }
}
