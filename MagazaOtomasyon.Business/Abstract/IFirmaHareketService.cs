using MagazaOtomasyon.Entities.ComplexType;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.Abstract
{
    public interface IFirmaHareketService
    {
        List<FirmaHareketDetail> firmaHareketDetails();
        FirmaHareket Add(FirmaHareket firmaHareket);
        List<Firma> GetFirmaAd(int firmaId);
    }
}
