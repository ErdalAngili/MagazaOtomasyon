﻿using MagazaOtomasyon.DataAccess.Abstract;
using MagazaOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.DataAccess.Concrete.EntityFramework
{
    public class EfFaturaBilgiDal:EfEntityRepositoryBase<FaturaBilgi,MagazaOtomasyonContext>,IFaturaBilgiDal
    {
    }
}
