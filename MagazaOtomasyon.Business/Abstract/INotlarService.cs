using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.Abstract
{
    public interface INotlarService
    {
        List<Not> GetAll();
        List<Not> NotHitap(string hitap);
        Not Add(Not not);
        Not Delete(Not not);
        Not Update(Not not);
    }
}
