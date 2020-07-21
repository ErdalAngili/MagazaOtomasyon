using MagazaOtomasyon.DataAccess.Abstract;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.DataAccess.Concrete.EntityFramework
{
    public class EfUrunDal:EfEntityRepositoryBase<Urun,MagazaOtomasyonContext>,IUrunDal
    {
    }
}
