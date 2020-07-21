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
    public class StokMap:EntityTypeConfiguration<Stok>
    {
        public StokMap()
        {
            HasKey(p => p.StokId);
            Property(p => p.StokId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.StokTur).HasMaxLength(20);
        }
    }
}
