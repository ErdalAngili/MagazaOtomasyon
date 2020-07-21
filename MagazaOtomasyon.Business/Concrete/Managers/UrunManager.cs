using MagazaOtomasyon.Business.Abstract;
using MagazaOtomasyon.Business.Aspects.Postsharp;
using MagazaOtomasyon.Business.CrossCuttingConcerns.Validation.FluentValidation;
using MagazaOtomasyon.Business.ValidationRules.FluentValidation;
using MagazaOtomasyon.DataAccess.Abstract;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.Concrete.Managers
{
    public class UrunManager : IUrunService
    {
        IUrunDal _urunDal;
        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }
        [FluentValidationAspect(typeof(UrunValidator))]
        public Urun Add(Urun urun)
        {
            return _urunDal.Add(urun);
        }

        public Urun Delete(Urun urun)
        {
           _urunDal.Delete(urun);
            return urun;
        }

        public List<Urun> GetAll()
        {
            return _urunDal.GetAll();
        }

        public List<Urun> GetUrunAd(string key)
        {
            return _urunDal.GetAll(p => p.UrunAd.ToLower().Contains(key.ToLower()));
        }

        [FluentValidationAspect(typeof(UrunValidator))]
        public Urun Update(Urun urun)
        {
            return _urunDal.Update(urun);
        }
    }
}
