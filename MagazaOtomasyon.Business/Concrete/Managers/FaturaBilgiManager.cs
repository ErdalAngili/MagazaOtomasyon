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
    public class FaturaBilgiManager : IFaturaBilgiService
    {
        IFaturaBilgiDal _faturaBilgiDal;
        IPersonelDal _personelDal;
        public FaturaBilgiManager(IFaturaBilgiDal faturaBilgiDal, IPersonelDal personelDal)
        {
            _faturaBilgiDal = faturaBilgiDal;
            _personelDal = personelDal;
        }
        [FluentValidationAspect(typeof(FaturaBilgiValidator))]
        public FaturaBilgi Add(FaturaBilgi faturaBilgi)
        {
            return _faturaBilgiDal.Add(faturaBilgi);
        }

        public FaturaBilgi Delete(FaturaBilgi faturaBilgi)
        {
            _faturaBilgiDal.Delete(faturaBilgi);
            return faturaBilgi;
        }

        public List<FaturaBilgi> GetAll()
        {
           return _faturaBilgiDal.GetAll();
        }

        public List<Personel> GetPersonelAd(int personelId)
        {
            return _personelDal.GetAll(p => p.PersonelId == personelId);
        }

        public List<FaturaBilgi> GetSiraNo(int key)
        {
           return _faturaBilgiDal.GetAll(p => p.SiraNo.ToString().Contains(key.ToString()));
        }

        public List<FaturaBilgi> PersonelAd(int personelad)
        {
            return _faturaBilgiDal.GetAll(p => p.TeslimEden == personelad.ToString());
        }

        [FluentValidationAspect(typeof(FaturaBilgiValidator))]
        public FaturaBilgi Update(FaturaBilgi faturaBilgi)
        {
            return _faturaBilgiDal.Update(faturaBilgi);
        }
    }
}
