using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.Abstract
{
    public interface IUrunService
    {
        List<Urun> GetAll();
        List<Urun> GetUrunAd(string key);
        Urun Add(Urun urun);
        Urun Delete(Urun urun);
        Urun Update(Urun urun);
    }
}
