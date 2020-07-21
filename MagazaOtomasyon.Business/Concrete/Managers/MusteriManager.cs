using MagazaOtomasyon.Business.Abstract;
using MagazaOtomasyon.Business.Aspects.Postsharp;
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
    public class MusteriManager : IMusteriService
    {
        IMusteriDal _musteriDal;
        public MusteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;
        }
        [FluentValidationAspect(typeof(MusteriValidator))]
        public Musteri Add(Musteri musteri)
        {
            return _musteriDal.Add(musteri);
        }

        public Musteri Delete(Musteri musteri)
        {
            _musteriDal.Delete(musteri);
            return musteri;
        }

        public List<Musteri> GetAll()
        {
            return _musteriDal.GetAll();
        }

        public List<Musteri> GetUrunAd(string key)
        {
            return _musteriDal.GetAll(p => p.Ad.ToLower().Contains(key.ToLower()));
        }

        [FluentValidationAspect(typeof(MusteriValidator))]
        public Musteri Update(Musteri musteri)
        {
            return _musteriDal.Update(musteri);
        }
    }
}
