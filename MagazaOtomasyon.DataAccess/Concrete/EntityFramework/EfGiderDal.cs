using MagazaOtomasyon.DataAccess.Abstract;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.DataAccess.Concrete.EntityFramework
{
    public class EfGiderDal : EfEntityRepositoryBase<Gider, MagazaOtomasyonContext>, IGiderDal
    {
        public decimal PersonelMaasToplam()
        {
            using (MagazaOtomasyonContext context = new MagazaOtomasyonContext())
            {
                decimal maas = context.Giderler.Sum(p => p.Maaslar);
                return maas;
            }
        }

        public decimal ToplamGider()
        {
            using (MagazaOtomasyonContext context = new MagazaOtomasyonContext())
            {
                decimal dogalgaz = context.Giderler.Sum(p => p.Dogalgaz);
                decimal su = context.Giderler.Sum(p => p.Su);
                decimal elektrik = context.Giderler.Sum(p => p.Elektrik);
                decimal internet = context.Giderler.Sum(p => p.Internet);
                decimal ekstra = context.Giderler.Sum(p => p.Ekstra);
                return dogalgaz + su + elektrik + internet + ekstra;
            }
        }
    }
}
