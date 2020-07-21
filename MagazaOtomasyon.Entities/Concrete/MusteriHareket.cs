using MagazaOtomasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Entities.Concrete
{
    public class MusteriHareket:IEntity
    {
        public int MusteriHareketId { get; set; }
        public int UrunId { get; set; }
        public int Miktar { get; set; }
        public int PersonelId { get; set; }
        public int MusteriId { get; set; }
        public int FiyatId { get; set; }
        public int ToplamId { get; set; }
        public int FaturaId { get; set; }
    }
}
