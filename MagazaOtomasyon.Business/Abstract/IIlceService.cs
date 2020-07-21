using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.Abstract
{
    public interface IIlceService
    {
        List<Ilce> GetIlByIlce(int IlId);
    }
}
