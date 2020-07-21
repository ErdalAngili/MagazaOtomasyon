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
    public class Ilcemanager:IIlceService
    {
        IIlceDal _ılceDal;
        public Ilcemanager(IIlceDal ılceDal)
        {
            _ılceDal = ılceDal;
        }

        public List<Ilce> GetIlByIlce(int IlId)
        {
            return _ılceDal.GetAll(p => p.IlId == IlId);
        }

    }
}
