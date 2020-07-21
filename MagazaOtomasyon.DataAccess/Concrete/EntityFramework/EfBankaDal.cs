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
    public class EfBankaDal : EfEntityRepositoryBase<Banka, MagazaOtomasyonContext>, IBankaDal
    {
        public List<BankaDetail> GetBankaDetails()
        {
            using (MagazaOtomasyonContext context = new MagazaOtomasyonContext())
            {
                var result = from p in context.Bankalar
                             join c in context.Firmalar on p.FirmaId equals c.FirmaId
                             select new BankaDetail
                             {
                                 BankaId = p.BankaId,
                                 BankaAdı=p.BankaAdı,
                                 Il=p.Il,
                                 Ilce=p.Ilce,
                                 Sube=p.Sube,
                                 Iban=p.Iban,
                                 HesapNo=p.HesapNo,
                                 Yetkili=p.Yetkili,
                                 Telefon=p.Telefon,
                                 Tarih=p.Tarih,
                                 HesapTuru=p.HesapTuru,
                                 FirmaAd=c.FirmaAd
                             };
                return result.ToList();
            }
        }
    }
}
