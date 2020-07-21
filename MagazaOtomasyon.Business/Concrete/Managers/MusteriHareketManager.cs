using MagazaOtomasyon.Business.Abstract;
using MagazaOtomasyon.DataAccess.Abstract;
using MagazaOtomasyon.Entities.ComplexType;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.Concrete.Managers
{
    public class MusteriHareketManager : IMusteriHareketService
    {
        IMusteriHareketDal _musteriHareketDal;
        IUrunDal _urunDal;
        IFaturaBilgiDal _FaturaBilgi;
        public MusteriHareketManager(IMusteriHareketDal musteriHareketDal,IUrunDal urunDal,IFaturaBilgiDal faturaBilgiDal)
        {
            _musteriHareketDal = musteriHareketDal;
            _urunDal = urunDal;
            _FaturaBilgi = faturaBilgiDal;
        }

        public MusteriHareket Add(MusteriHareket musteriHareket)
        {
            return _musteriHareketDal.Add(musteriHareket);
        }

        public List<MusteeriHareketDetail> MusteeriHareketDetails()
        {
            return _musteriHareketDal.musteeriHareketDetails();
        }

        public List<Urun> uruns(int urunId)
        {
            return _urunDal.GetAll(p => p.UrunId == urunId);
        }
    }
}
