using MagazaOtomasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Entities.Concrete
{
    public class Not:IEntity
    {
        public int NotId { get; set; }
        public string Tarih { get; set; }
        public string Saat { get; set; }
        public string Baslik { get; set; }
        public string Detay { get; set; }
        public string Olusturan { get; set; }
        public string Hitap { get; set; }
    }
}
