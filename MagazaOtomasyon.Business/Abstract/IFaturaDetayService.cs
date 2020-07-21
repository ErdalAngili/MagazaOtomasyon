using MagazaOtomasyon.Entities.ComplexType;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.Abstract
{
    public interface IFaturaDetayService
    {
        List<FaturaDetayDetail> GetfaturaDetayDetails();
        List<FaturaDetay> Detay(int id);
        List<FaturaBilgi> GetFaturaDetayByFaturaBilgi(int AliciId);
        FaturaDetay Add(FaturaDetay faturaDetay);
        FaturaDetay Update(FaturaDetay faturaDetay);
    }
}
