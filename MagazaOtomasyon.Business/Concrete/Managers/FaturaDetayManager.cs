using MagazaOtomasyon.Business.Abstract;
using MagazaOtomasyon.Business.Aspects.Postsharp;
using MagazaOtomasyon.Business.ValidationRules.FluentValidation;
using MagazaOtomasyon.DataAccess.Abstract;
using MagazaOtomasyon.Entities.ComplexType;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.Concrete.Managers
{
    public class FaturaDetayManager : IFaturaDetayService
    {
        IFaturaDetayDal _faturaDetayDal;
        IFaturaBilgiDal _faturaBilgiDal;
        public FaturaDetayManager(IFaturaBilgiDal faturaBilgiDal, IFaturaDetayDal faturaDetayDal)
        {
            _faturaBilgiDal = faturaBilgiDal;
            _faturaDetayDal = faturaDetayDal;
        }
        [FluentValidationAspect(typeof(FaturaDetayValidator))]
        public FaturaDetay Add(FaturaDetay faturaDetay)
        {
            return _faturaDetayDal.Add(faturaDetay);
        }

        public List<FaturaDetay> Detay(int id)
        {
            return _faturaDetayDal.GetAll(p => p.FaturaId == id);
        }

        public List<FaturaBilgi> GetFaturaDetayByFaturaBilgi(int AliciId)
        {
            return _faturaBilgiDal.GetAll(p => p.FaturaBilgiId == AliciId);
        }

        public List<FaturaDetayDetail> GetfaturaDetayDetails()
        {
            return _faturaDetayDal.GetfaturaDetayDetails();
        }
        [FluentValidationAspect(typeof(FaturaDetayValidator))]
        public FaturaDetay Update(FaturaDetay faturaDetay)
        {
            return _faturaDetayDal.Update(faturaDetay);
        }

    }
}
