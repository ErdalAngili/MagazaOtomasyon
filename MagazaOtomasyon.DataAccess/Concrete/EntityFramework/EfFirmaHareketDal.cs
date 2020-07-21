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
    public class EfFirmaHareketDal : EfEntityRepositoryBase<FirmaHareket, MagazaOtomasyonContext>, IFirmaHareketDal
    {
        public List<FirmaHareketDetail> firmaHareketDetails()
        {
            using (MagazaOtomasyonContext context = new MagazaOtomasyonContext())
            {
                var result = from p in context.FirmaHareketler
                             join c in context.Urunler on p.UrunId equals c.UrunId
                             join x in context.Personeller on p.Personel equals x.PersonelId
                             join z in context.Firmalar on p.Firma equals z.FirmaId
                             join b in context.FaturaBilgiler on p.FaturaId equals b.FaturaBilgiId
                             select new FirmaHareketDetail
                             {
                                 FirmaHareketId = p.FirmaHareketId,
                                 UrunAd=c.UrunAd,
                                 Adet=p.Adet,
                                 PersonelAdSoyad= x.Ad + " " + x.Soyad,
                                 FirmaAd =z.FirmaAd,
                                 Fiyat=p.Fiyat,
                                 Toplam=p.Toplam,
                                 FaturaSiraNo=b.SiraNo,
                             };
                return result.ToList();
            }
        }
    }
}
