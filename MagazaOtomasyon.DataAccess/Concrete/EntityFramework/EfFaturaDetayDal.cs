using MagazaOtomasyon.DataAccess.Abstract;
using MagazaOtomasyon.Entities.ComplexType;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.DataAccess.Concrete.EntityFramework
{
    public class EfFaturaDetayDal:EfEntityRepositoryBase<FaturaDetay,MagazaOtomasyonContext>,IFaturaDetayDal
    {
        public List<FaturaDetayDetail> GetfaturaDetayDetails()
        {
            using (MagazaOtomasyonContext context = new MagazaOtomasyonContext())
            {
                var result = from p in context.FaturaDetaylar
                             join c in context.FaturaBilgiler on p.FaturaId equals c.FaturaBilgiId
                             select new FaturaDetayDetail
                             {
                                 FaturaUrunId = p.FaturaUrunId,
                                 UrunAd = p.UrunAd,
                                 Miktar = p.Miktar,
                                 Fiyat = p.Fiyat,
                                 Tutar = p.Tutar,
                                 AliciAd = c.Alici
                             };
                return result.ToList();
            }
        }

        public decimal ToplamTutar()
        {
            using (MagazaOtomasyonContext context = new MagazaOtomasyonContext())
            {
                decimal total = context.FaturaDetaylar.Sum(p => p.Tutar);
                return total;
            }
        }
    }
}
