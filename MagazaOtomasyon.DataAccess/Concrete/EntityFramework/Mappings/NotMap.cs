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
    public class NotMap:EntityTypeConfiguration<Not>
    {
        public NotMap()
        {
            HasKey(p => p.NotId);
            Property(p => p.NotId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Tarih).HasMaxLength(10);
            Property(p => p.Saat).HasMaxLength(6);
            Property(p => p.Baslik).HasMaxLength(50);
            Property(p => p.Detay).HasMaxLength(300);
            Property(p => p.Olusturan).HasMaxLength(25);
            Property(p => p.Hitap).HasMaxLength(20);
        }
    }
}
