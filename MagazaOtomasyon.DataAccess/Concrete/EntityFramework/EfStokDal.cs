using MagazaOtomasyon.DataAccess.Abstract;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.DataAccess.Concrete.EntityFramework
{
    public class EfStokDal : EfEntityRepositoryBase<Stok, MagazaOtomasyonContext>, IStokDal
    {
        public int StokToplamSayisi()
        {
            using (MagazaOtomasyonContext context = new MagazaOtomasyonContext())
            {
                var StokToplam = context.Stoklar.Sum(p => p.StokAdet);
                return StokToplam;
            }
        }
    }
}
