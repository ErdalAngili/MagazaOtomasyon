using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.Abstract
{
    public interface IMusteriService
    {
        List<Musteri> GetAll();
        List<Musteri> GetUrunAd(string key);
        Musteri Add(Musteri musteri);
        Musteri Delete(Musteri musteri);
        Musteri Update(Musteri musteri);
    }
}
