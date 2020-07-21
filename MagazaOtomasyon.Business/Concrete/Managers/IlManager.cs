using MagazaOtomasyon.Business.Abstract;
using MagazaOtomasyon.DataAccess.Abstract;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.Concrete.Managers
{
    public class IlManager : IIlService
    {
        IIlDal _ılDal;
        public IlManager(IIlDal ılDal)
        {
            _ılDal = ılDal;
        }

        public List<Il> GetAll()
        {
            return _ılDal.GetAll();
        }
    }
}
