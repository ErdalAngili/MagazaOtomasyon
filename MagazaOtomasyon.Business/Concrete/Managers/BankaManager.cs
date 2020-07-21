using MagazaOtomasyon.Business.Abstract;
using MagazaOtomasyon.Business.Aspects.Postsharp;
using MagazaOtomasyon.Business.ValidationRules.FluentValidation;
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
    public class BankaManager : IBankaService
    {
        IBankaDal _bankaDal;
        IFirmaDal _firmaDal;
        public BankaManager(IBankaDal bankaDal,IFirmaDal firmaDal)
        {
            _bankaDal = bankaDal;
            _firmaDal = firmaDal;
        }
        [FluentValidationAspect(typeof(BankaValidator))]
        public Banka Add(Banka banka)
        {
            return _bankaDal.Add(banka);
        }

        public Banka Delete(Banka banka)
        {
            _bankaDal.Delete(banka);
            return banka;
        }

        public List<Firma> GetBankaByFırma(int FirmaId)
        {
            return _firmaDal.GetAll(p => p.FirmaId == FirmaId);
        }

        public List<BankaDetail> GetbankDetails()
        {
            return _bankaDal.GetBankaDetails();
        }

        public List<Banka> GetYetkiliAd(string key)
        {
            return _bankaDal.GetAll(p => p.Yetkili.ToLower().Contains(key.ToLower()));
        }
        [FluentValidationAspect(typeof(BankaValidator))]
        public Banka Update(Banka banka)
        {
            return _bankaDal.Update(banka);
        }
    }
}
