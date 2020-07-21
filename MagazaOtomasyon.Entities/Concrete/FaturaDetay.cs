using MagazaOtomasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Entities.Concrete
{
    public class FaturaDetay:IEntity
    {
        public int FaturaUrunId { get; set; }
        public string UrunAd { get; set; }
        public int Miktar { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Tutar { get; set; }
        public int FaturaId { get; set; }
    }
}
