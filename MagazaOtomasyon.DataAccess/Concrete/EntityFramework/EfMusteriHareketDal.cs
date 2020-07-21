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
    public class EfMusteriHareketDal : EfEntityRepositoryBase<MusteriHareket, MagazaOtomasyonContext>, IMusteriHareketDal
    {
        public List<MusteeriHareketDetail> musteeriHareketDetails()
        {
            using (MagazaOtomasyonContext context = new MagazaOtomasyonContext())
            {
                var result = from p in context.MusteriHareketler
                             join c in context.Stoklar on p.UrunId equals c.StokId
                             join x in context.Personeller on p.PersonelId equals x.PersonelId
                             join z in context.Musteriler on p.MusteriId equals z.MusteriId
                             join b in context.FaturaBilgiler on p.FaturaId equals b.FaturaBilgiId
                             select new MusteeriHareketDetail
                             {
                                 MusteriHareketId = p.MusteriHareketId,
                                 UrunAd = c.StokTur,
                                 PersonelAdSoyad = x.Ad + " " + x.Soyad,
                                 MusteriAdSoyad = z.Ad + " " + z.Soyad,
                                 Fiyat =p.FiyatId,
                                 FaturaSiraNo=b.SiraNo,
                                 Miktar=p.Miktar,
                                 Toplam=p.ToplamId
                             };
                return result.ToList();
            }
        }
    }
}
