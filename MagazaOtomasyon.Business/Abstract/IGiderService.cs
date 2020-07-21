using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.Abstract
{
    public interface IGiderService
    {
        List<Gider> GetAll();
        List<Gider> GetGiderYil(string key);
        Gider Add(Gider gider);
        Gider Delete(Gider gider);
        Gider Update(Gider gider);
    }
}
