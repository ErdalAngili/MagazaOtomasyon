﻿using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.DataAccess.Abstract
{
    public interface IGiderDal:IEntityRepository<Gider>
    {
        decimal ToplamGider();
        decimal PersonelMaasToplam();
    }
}
