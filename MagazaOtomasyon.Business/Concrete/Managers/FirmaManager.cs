using MagazaOtomasyon.Business.Abstract;
using MagazaOtomasyon.Business.Aspects.Postsharp;
using MagazaOtomasyon.Business.ValidationRules.FluentValidation;
using MagazaOtomasyon.DataAccess.Abstract;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.Concrete.Managers
{
    public class FirmaManager : IFirmaService
    {
        IFirmaDal _firmaDal;
        public FirmaManager(IFirmaDal firmaDal)
        {
            _firmaDal = firmaDal;
        }
        [FluentValidationAspect(typeof(FirmaValidator))]
        public Firma Add(Firma firma)
        {
            return _firmaDal.Add(firma);
        }

        public Firma Delete(Firma firma)
        {
            _firmaDal.Delete(firma);
            return firma;
        }

        public List<Firma> GetAll()
        {
            return _firmaDal.GetAll();
        }

        public List<Firma> GetFirmaId(int FirmaId)
        {
            return _firmaDal.GetAll(p => p.FirmaId == FirmaId);
        }

        public List<Firma> GetUrunAd(string key)
        {
            return _firmaDal.GetAll(p => p.FirmaAd.ToLower().Contains(key.ToLower()));
        }
        [FluentValidationAspect(typeof(FirmaValidator))]
        public Firma Update(Firma firma)
        {
            return _firmaDal.Update(firma);
        }
    }
}
