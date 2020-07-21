using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MagazaOtomasyon.DataAccess.Concrete.EntityFramework;
using MagazaOtomasyon.Business.DependencyResolvers.Ninject;

namespace MagazaOtomasyon.WinUI.Froms.FrmKasa
{
    public partial class FrmKasaList : DevExpress.XtraEditors.XtraForm
    {
        public FrmKasaList()
        {
            InitializeComponent();
            _efMusteriHareketDal = InstanceFactory.GetInstance<EfMusteriHareketDal>();
            _efFirmaHareketDal = InstanceFactory.GetInstance<EfFirmaHareketDal>();
            _efFaturaDetayDal = InstanceFactory.GetInstance<EfFaturaDetayDal>();
            _efGiderDal = InstanceFactory.GetInstance<EfGiderDal>();
            _efMusteriDal = InstanceFactory.GetInstance<EfMusteriDal>();
            _efFirmaDal = InstanceFactory.GetInstance<EfFirmaDal>();
            _efPersonelDal = InstanceFactory.GetInstance<EfPersonelDal>();
            _efStokDal = InstanceFactory.GetInstance<EfStokDal>();
        }
        EfMusteriHareketDal _efMusteriHareketDal;
        EfFirmaHareketDal _efFirmaHareketDal;
        EfFaturaDetayDal _efFaturaDetayDal;
        EfGiderDal _efGiderDal;
        EfMusteriDal _efMusteriDal;
        EfFirmaDal _efFirmaDal;
        EfPersonelDal _efPersonelDal;
        EfStokDal _efStokDal;
        public void MusteriListele()
        {
            gridControl1.DataSource = _efMusteriHareketDal.musteeriHareketDetails();
        }
        public void FirmaListele()
        {
            gridControl2.DataSource = _efFirmaHareketDal.firmaHareketDetails();
        }
        public void ToplamTutar()
        {
            lblToplamTutar.Text = _efFaturaDetayDal.ToplamTutar().ToString();
        }
        public void ToplamGider()
        {
            lblOdemeler.Text = _efGiderDal.ToplamGider().ToString();
        }
        public void PersonelMaas()
        {
            lblPersonelMaas.Text = _efGiderDal.PersonelMaasToplam().ToString();
        }
        public void MusteriSayisiToplam()
        {
            lblMusteriSayisi.Text = _efMusteriDal.musteriToplam().ToString();
        }
        public void MusteriSehirSayisi()
        {
            lblMusteriSehirSayisi.Text = _efMusteriDal.musteriSehirToplam().ToString();
        }
        public void FirmaSayisiToplam()
        {
            lblFirmaSayisi.Text = _efFirmaDal.FirmaSayisi().ToString();
        }
        public void FirmaSehirSayisi()
        {
            lblFirmaSehirSayisi.Text = _efFirmaDal.FirmaSehirSayisi().ToString();
        }
        public void PersonelToplamSayisi()
        {
            lblPersonelSayisi.Text = _efPersonelDal.PersonelToplamSayisi().ToString();
        }
        public void StokToplamSayisi()
        {
            lblStok.Text = _efStokDal.StokToplamSayisi().ToString();
        }
        private void FrmKasaList_Load(object sender, EventArgs e)
        {
            MusteriListele();
            FirmaListele();
            ToplamTutar();
            ToplamGider();
            PersonelMaas();
            MusteriSayisiToplam();
            MusteriSehirSayisi();
            FirmaSayisiToplam();
            FirmaSehirSayisi();
            PersonelToplamSayisi();
            StokToplamSayisi();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac==60)
            {
                MusteriListele();
                FirmaListele();
                ToplamTutar();
                ToplamGider();
                PersonelMaas();
                MusteriSayisiToplam();
                MusteriSehirSayisi();
                FirmaSayisiToplam();
                FirmaSehirSayisi();
                PersonelToplamSayisi();
                StokToplamSayisi();
            }
            if (sayac==61)
            {
                sayac = 0;
            }
        }
    }
}