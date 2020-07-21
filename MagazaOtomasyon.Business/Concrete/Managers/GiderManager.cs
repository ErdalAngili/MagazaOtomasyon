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
    public class GiderManager : IGiderService
    {
        IGiderDal _giderDal;
        public GiderManager(IGiderDal giderDal)
        {
            _giderDal = giderDal;
        }
        [FluentValidationAspect(typeof(GiderValidator))]
        public Gider Add(Gider gider)
        {
            return _giderDal.Add(gider);
        }

        public Gider Delete(Gider gider)
        {
            _giderDal.Delete(gider);
            return gider;
        }

        public List<Gider> GetAll()
        {
            return _giderDal.GetAll();
        }

        public List<Gider> GetGiderYil(string key)
        {
            return _giderDal.GetAll(p => p.Yil.ToLower().Contains(key.ToLower()));
        }
        [FluentValidationAspect(typeof(GiderValidator))]
        public Gider Update(Gider gider)
        {
            return _giderDal.Update(gider);
        }
    }
}
