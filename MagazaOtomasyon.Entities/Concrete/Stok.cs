using MagazaOtomasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Entities.Concrete
{
    public class Stok:IEntity
    {
        public int StokId { get; set; }
        public string StokTur { get; set; }
        public int StokAdet { get; set; }
    }
}
