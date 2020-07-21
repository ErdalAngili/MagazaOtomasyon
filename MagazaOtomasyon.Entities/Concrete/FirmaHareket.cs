using MagazaOtomasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Entities.Concrete
{
    public class FirmaHareket:IEntity
    {
        public int FirmaHareketId { get; set; }
        public int UrunId { get; set; }
        public int Adet { get; set; }
        public int Personel { get; set; }
        public int Firma { get; set; }
        public int Fiyat { get; set; }
        public int Toplam { get; set; }
        public int FaturaId { get; set; }
    }
}
