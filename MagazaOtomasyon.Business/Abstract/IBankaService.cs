using MagazaOtomasyon.Entities.ComplexType;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.Abstract
{
    public interface IBankaService
    {
        Banka Add(Banka banka);
        Banka Delete(Banka banka);
        Banka Update(Banka banka);
        List<BankaDetail> GetbankDetails();
        List<Banka> GetYetkiliAd(string key);
        List<Firma> GetBankaByFırma(int FirmaId);
    }
}
