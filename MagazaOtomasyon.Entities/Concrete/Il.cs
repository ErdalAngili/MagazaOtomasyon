using MagazaOtomasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Entities.Concrete
{
    public class Il:IEntity
    {
        [Key]
        public int IlId { get; set; }
        public string Sehir { get; set; }
        public virtual ICollection<Ilce> Ilceler { get; set; }
    }
}
