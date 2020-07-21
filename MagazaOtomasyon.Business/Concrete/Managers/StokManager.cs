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
    public class StokManager : IStokService
    {
        IStokDal _stokDal;
        public StokManager(IStokDal stokDal)
        {
            _stokDal = stokDal;
        }
        public Stok Add(Stok stok)
        {
            return _stokDal.Add(stok);
        }

        public List<Stok> GetAll()
        {
            return _stokDal.GetAll();
        }

        public List<Stok> GetUrunAdet(int UrunId)
        {
            return _stokDal.GetAll(p => p.StokId == UrunId);
        }

        public Stok Update(Stok stok)
        {
            return _stokDal.Update(stok);
        }
    }
}
