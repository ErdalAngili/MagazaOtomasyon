﻿using MagazaOtomasyon.Entities.ComplexType;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.Abstract
{
    public interface IMusteriHareketService
    {
        List<MusteeriHareketDetail> MusteeriHareketDetails();
        MusteriHareket Add(MusteriHareket musteriHareket);
        List<Urun> uruns(int urunId);
    }
}
