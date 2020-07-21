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
    public class FirmaHareketManager : IFirmaHareketService
    {
        IFirmaHareketDal _firmaHareketDal;
        IFirmaDal _firmaDal;
        public FirmaHareketManager(IFirmaHareketDal firmaHareketDal, IFirmaDal firmaDal)
        {
            _firmaHareketDal = firmaHareketDal;
            _firmaDal = firmaDal;
        }
        public FirmaHareket Add(FirmaHareket firmaHareket)
        {
            return _firmaHareketDal.Add(firmaHareket);
        }

        public List<FirmaHareketDetail> firmaHareketDetails()
        {
            return _firmaHareketDal.firmaHareketDetails();
        }

        public List<Firma> GetFirmaAd(int firmaId)
        {
            return _firmaDal.GetAll(p => p.FirmaId == firmaId);
        }
    }
}
