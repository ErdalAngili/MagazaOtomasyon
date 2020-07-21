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
    public class NotManager : INotlarService
    {
        INotDal _notDal;
        public NotManager(INotDal notDal)
        {
            _notDal = notDal;
        }
        [FluentValidationAspect(typeof(NotValidator))]
        public Not Add(Not not)
        {
            return _notDal.Add(not);
        }

        public Not Delete(Not not)
        {
            _notDal.Delete(not);
            return not;
        }

        public List<Not> GetAll()
        {
            return _notDal.GetAll();
        }

        public List<Not> NotHitap(string hitap)
        {
            return _notDal.GetAll(p => p.Hitap.ToLower().Contains(hitap.ToLower()));
        }
        [FluentValidationAspect(typeof(NotValidator))]
        public Not Update(Not not)
        {
            return _notDal.Update(not);
        }
    }
}
