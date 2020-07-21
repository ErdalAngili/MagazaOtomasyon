using MagazaOtomasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Entities.Concrete
{
    public class FaturaBilgi:IEntity
    {
        public int FaturaBilgiId { get; set; }
        public string Seri { get; set; }
        public string SiraNo { get; set; }
        public string Tarih { get; set; }
        public string Saat { get; set; }
        public string VergiDaire { get; set; }
        public string Alici { get; set; }
        public string TeslimEden { get; set; }
        public string TeslimAlan { get; set; }
    }
}
