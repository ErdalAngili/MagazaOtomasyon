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
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;
        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }
        [FluentValidationAspect(typeof(PersonelValidator))]
        public Personel Add(Personel firma)
        {
            return _personelDal.Add(firma);
        }
        public Personel Delete(Personel firma)
        {
            _personelDal.Delete(firma);
            return firma;
        }

        public List<Personel> GetAll()
        {
            return _personelDal.GetAll();
        }

        public List<Personel> GetPersonelAd(string key)
        {
            return _personelDal.GetAll(p => p.Ad.ToLower().Contains(key.ToLower()));
        }
        [FluentValidationAspect(typeof(PersonelValidator))]
        public Personel Update(Personel firma)
        {
            return _personelDal.Update(firma);
        }
    }
}
