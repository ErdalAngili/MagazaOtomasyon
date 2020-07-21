using MagazaOtomasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Entities.Concrete
{
    public class Gider:IEntity
    {
        public int GiderId { get; set; }
        public string Ay { get; set; }
        public string Yil { get; set; }
        public decimal Elektrik { get; set; }
        public decimal Su { get; set; }
        public decimal Dogalgaz { get; set; }
        public decimal Internet { get; set; }
        public decimal Maaslar { get; set; }
        public decimal Ekstra { get; set; }
        public string Notlar { get; set; }
    }
}
