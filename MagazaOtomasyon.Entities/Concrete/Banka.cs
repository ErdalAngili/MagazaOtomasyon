﻿using MagazaOtomasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Entities.Concrete
{
    public class Banka:IEntity
    {
        public int BankaId { get; set; }
        public string BankaAdı { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Sube { get; set; }
        public string Iban { get; set; }
        public string HesapNo { get; set; }
        public string Yetkili { get; set; }
        public string Telefon { get; set; }
        public string Tarih { get; set; }
        public string HesapTuru { get; set; }
        public int FirmaId { get; set; }
    }
}
