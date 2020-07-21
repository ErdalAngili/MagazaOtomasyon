using MagazaOtomasyon.Business.Abstract;
using MagazaOtomasyon.Business.Concrete.Managers;
using MagazaOtomasyon.DataAccess.Abstract;
using MagazaOtomasyon.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IUrunService>().To<UrunManager>().InSingletonScope();
            Bind<IUrunDal>().To<EfUrunDal>();
            Bind<IMusteriService>().To<MusteriManager>().InSingletonScope();
            Bind<IMusteriDal>().To<EfMusteriDal>();
            Bind<IIlService>().To<IlManager>().InSingletonScope();
            Bind<IIlDal>().To<EfIlDal>();
            Bind<IIlceService>().To<Ilcemanager>().InSingletonScope();
            Bind<IIlceDal>().To<EfIlceDal>();
            Bind<IFirmaService>().To<FirmaManager>().InSingletonScope();
            Bind<IFirmaDal>().To<EfFirmaDal>();
            Bind<IPersonelService>().To<PersonelManager>().InSingletonScope();
            Bind<IPersonelDal>().To<EfPersonelDal>();
            Bind<IGiderService>().To<GiderManager>().InSingletonScope();
            Bind<IGiderDal>().To<EfGiderDal>();
            Bind<IBankaService>().To<BankaManager>().InSingletonScope();
            Bind<IBankaDal>().To<EfBankaDal>();
            Bind<IFaturaBilgiService>().To<FaturaBilgiManager>().InSingletonScope();
            Bind<IFaturaBilgiDal>().To<EfFaturaBilgiDal>();
            Bind<IFaturaDetayService>().To<FaturaDetayManager>().InSingletonScope();
            Bind<IFaturaDetayDal>().To<EfFaturaDetayDal>();
            Bind<INotlarService>().To<NotManager>().InSingletonScope();
            Bind<INotDal>().To<EfNotDal>();
            Bind<IMusteriHareketService>().To<MusteriHareketManager>().InSingletonScope();
            Bind<IMusteriHareketDal>().To<EfMusteriHareketDal>();
            Bind<IFirmaHareketService>().To<FirmaHareketManager>().InSingletonScope();
            Bind<IFirmaHareketDal>().To<EfFirmaHareketDal>();
            Bind<IStokService>().To<StokManager>().InSingletonScope();
            Bind<IStokDal>().To<EfStokDal>();
            Bind<DbContext>().To<MagazaOtomasyonContext>();
        }
    }
}
