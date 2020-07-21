using MagazaOtomasyon.DataAccess.Abstract;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.DataAccess.Concrete.EntityFramework
{
    public class EfFirmaDal : EfEntityRepositoryBase<Firma, MagazaOtomasyonContext>, IFirmaDal
    {
        public int FirmaSayisi()
        {
            using (MagazaOtomasyonContext context = new MagazaOtomasyonContext())
            {
                var FirmaToplam = context.Firmalar.Count();
                return FirmaToplam;
            }
        }

        public int FirmaSehirSayisi()
        {
            using (MagazaOtomasyonContext context = new MagazaOtomasyonContext())
            {
                var FirmaSehirSayısıToplam = context.Firmalar.Select(p => p.Il).Distinct();
                return FirmaSehirSayısıToplam.Count();
            }
        }
    }
}
