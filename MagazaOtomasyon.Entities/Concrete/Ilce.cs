using MagazaOtomasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Entities.Concrete
{
    public class Ilce : IEntity
    {
        [Key]
        public int IlceId { get; set; }
        public string Ilceler { get; set; }
        public int IlId { get; set; }
        public virtual Il Iller { get; set; }
    }
}
