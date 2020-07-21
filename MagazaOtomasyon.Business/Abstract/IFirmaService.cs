using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.Abstract
{
    public interface IFirmaService
    {
        List<Firma> GetAll();
        List<Firma> GetFirmaId(int FirmaId);
        List<Firma> GetUrunAd(string key);
        Firma Add(Firma firma);
        Firma Delete(Firma firma);
        Firma Update(Firma firma);
    }
}
