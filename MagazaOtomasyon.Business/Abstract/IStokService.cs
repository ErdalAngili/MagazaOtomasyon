using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.Abstract
{
    public interface IStokService
    {
        List<Stok> GetAll();
        List<Stok> GetUrunAdet(int UrunId);
        Stok Add(Stok stok);
        Stok Update(Stok stok);
    }
}
