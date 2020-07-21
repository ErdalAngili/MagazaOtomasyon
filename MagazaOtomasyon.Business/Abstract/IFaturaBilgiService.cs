using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.Abstract
{
    public interface IFaturaBilgiService
    {
        List<FaturaBilgi> GetAll();
        List<FaturaBilgi> GetSiraNo(int key);
        FaturaBilgi Add(FaturaBilgi faturaBilgi);
        FaturaBilgi Delete(FaturaBilgi faturaBilgi);
        FaturaBilgi Update(FaturaBilgi faturaBilgi);
        List<Personel> GetPersonelAd(int PersonelId);
    }
}
