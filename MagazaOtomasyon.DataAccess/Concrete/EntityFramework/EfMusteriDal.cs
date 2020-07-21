using MagazaOtomasyon.DataAccess.Abstract;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.DataAccess.Concrete.EntityFramework
{
    public class EfMusteriDal : EfEntityRepositoryBase<Musteri, MagazaOtomasyonContext>, IMusteriDal
    {
        public int musteriSehirToplam()
        {
            using (MagazaOtomasyonContext context = new MagazaOtomasyonContext())
            {
                var MusteriSehirToplam = context.Musteriler.Select(p => p.Il).Distinct();
                return MusteriSehirToplam.Count();
            }
        }

        public int musteriToplam()
        {
            using (MagazaOtomasyonContext context = new MagazaOtomasyonContext())
            {
                int musteriToplam = context.Musteriler.Count();
                return musteriToplam;
            }
        }
    }
}
