using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.Abstract
{
    public interface IPersonelService
    {
        List<Personel> GetAll();
        List<Personel> GetPersonelAd(string key);
        Personel Add(Personel firma);
        Personel Delete(Personel firma);
        Personel Update(Personel firma);
    }
}
