using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Entities.ComplexType
{
    public class MusteeriHareketDetail
    {
        public int MusteriHareketId { get; set; }
        public string UrunAd { get; set; }
        public int Miktar { get; set; }
        public string PersonelAdSoyad { get; set; }
        public string MusteriAdSoyad { get; set; }
        public int Fiyat { get; set; }
        public int Toplam { get; set; }
        public string FaturaSiraNo { get; set; }
    }
}
