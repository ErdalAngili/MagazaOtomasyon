using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Entities.ComplexType
{
    public class FirmaHareketDetail
    {
        public int FirmaHareketId { get; set; }
        public string UrunAd { get; set; }
        public int Adet { get; set; }
        public string PersonelAdSoyad { get; set; }
        public string FirmaAd { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Toplam { get; set; }
        public string FaturaSiraNo { get; set; }
        public string Tarih { get; set; }
    }
}
