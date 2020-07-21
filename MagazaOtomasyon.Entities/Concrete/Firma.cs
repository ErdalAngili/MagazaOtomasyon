using MagazaOtomasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Entities.Concrete
{
    public class Firma:IEntity
    {
        public int FirmaId { get; set; }
        public string FirmaAd { get; set; }
        public string YetkiliStatu { get; set; }
        public string YetkiliAdSoyad { get; set; }
        public char YetkiliTc { get; set; }
        public string Sektor { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string Mail { get; set; }
        public string Fax { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string VergiDaire { get; set; }
        public string Adres { get; set; }
        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
    }
}
