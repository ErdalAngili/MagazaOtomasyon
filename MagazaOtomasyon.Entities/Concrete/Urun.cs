using MagazaOtomasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Entities.Concrete
{
    public class Urun:IEntity
    {
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public int Adet { get; set; }
        public decimal Maliyet { get; set; }
        public decimal SatisFiyat { get; set; }
        public string Detay { get; set; }
    }
}
