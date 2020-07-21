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
using MagazaOtomasyon.WinUI.Forms.FrmUrun;
using MagazaOtomasyon.WinUI.Froms.FrmMusteri;
using MagazaOtomasyon.WinUI.Froms.FrmFirmalar;
using MagazaOtomasyon.WinUI.Froms.FrmPersonel;
using MagazaOtomasyon.WinUI.Froms.FrmIletisim;
using MagazaOtomasyon.WinUI.Froms.FrmGiderler;
using MagazaOtomasyon.WinUI.Froms.FrmBanka;
using MagazaOtomasyon.WinUI.Froms.FrmFatura;
using MagazaOtomasyon.WinUI.Froms.FrmNotlar;
using MagazaOtomasyon.WinUI.Froms.FrmHareketler;
using MagazaOtomasyon.WinUI.Froms.FrmStok;
using MagazaOtomasyon.WinUI.Froms.FrmKasa;
using MagazaOtomasyon.WinUI.Froms.FrmAnaModul;

namespace MagazaOtomasyon.WinUI.Forms.FrmAnaSayfa
{
    public partial class FrmAnaModul : DevExpress.XtraEditors.XtraForm
    {
        public FrmAnaModul()
        {
            InitializeComponent();
        }
        FrmUrunList frmUrunList;
        private void barbtnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUrunList==null||frmUrunList.IsDisposed)
            {
                frmUrunList = new FrmUrunList();
                frmUrunList.MdiParent = this;
                frmUrunList.Show();
            }
        }
        FrmMusteriList frmMusteriList;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMusteriList == null || frmMusteriList.IsDisposed)
            {
                frmMusteriList = new FrmMusteriList();
                frmMusteriList.MdiParent = this;
                frmMusteriList.Show();
            }
        }
        FrmFirmaList frmFirmaList;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFirmaList == null || frmFirmaList.IsDisposed)
            {
                frmFirmaList = new FrmFirmaList();
                frmFirmaList.MdiParent = this;
                frmFirmaList.Show();
            }
        }
        FrmPersonelList frmPersonelList;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPersonelList == null || frmPersonelList.IsDisposed)
            {
                frmPersonelList = new FrmPersonelList();
                frmPersonelList.MdiParent = this;
                frmPersonelList.Show();
            }
        }

        FrmIletisimList frmIletisimList;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmIletisimList==null||frmIletisimList.IsDisposed)
            {
                frmIletisimList = new FrmIletisimList();
                frmIletisimList.MdiParent = this;
                frmIletisimList.Show();
            }
        }
        FrmGiderlerList frmGiderlerList;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmGiderlerList==null||frmGiderlerList.IsDisposed)
            {
                frmGiderlerList = new FrmGiderlerList();
                frmGiderlerList.MdiParent = this;
                frmGiderlerList.Show();
            }
        }
        FrmBankaList frmBankaList;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmBankaList == null || frmBankaList.IsDisposed)
            {
                frmBankaList = new FrmBankaList();
                frmBankaList.MdiParent = this;
                frmBankaList.Show();
            }
        }
        FrmFaturaList frmFaturaList;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFaturaList == null || frmFaturaList.IsDisposed)
            {
                frmFaturaList = new FrmFaturaList();
                frmFaturaList.MdiParent = this;
                frmFaturaList.Show();
            }
        }
        FrmNotlarList frmNotlarList;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmNotlarList == null || frmNotlarList.IsDisposed)
            {
                frmNotlarList = new FrmNotlarList();
                frmNotlarList.MdiParent = this;
                frmNotlarList.Show();
            }
        }
        FrmHareket frmHareketler;
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmHareketler == null || frmHareketler.IsDisposed)
            {
                frmHareketler = new FrmHareket();
                frmHareketler.MdiParent = this;
                frmHareketler.Show();
            }
        }
        FrmStokList _frmStokList;
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_frmStokList == null || _frmStokList.IsDisposed)
            {
                _frmStokList = new FrmStokList();
                _frmStokList.MdiParent = this;
                _frmStokList.Show();
            }
        }
        FrmKasaList _frmKasaList;
        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_frmKasaList == null || _frmKasaList.IsDisposed)
            {
                _frmKasaList = new FrmKasaList();
                _frmKasaList.MdiParent = this;
                _frmKasaList.Show();
            }
        }

        FrmAnaSayfaModul _frmAnaSayfaModul;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_frmAnaSayfaModul == null || _frmAnaSayfaModul.IsDisposed)
            {
                _frmAnaSayfaModul = new FrmAnaSayfaModul();
                _frmAnaSayfaModul.MdiParent = this;
                _frmAnaSayfaModul.Show();
            }
        }

        private void FrmAnaModul_Load(object sender, EventArgs e)
        {
            if (_frmAnaSayfaModul == null)
            {
                _frmAnaSayfaModul = new FrmAnaSayfaModul();
                _frmAnaSayfaModul.MdiParent = this;
                _frmAnaSayfaModul.Show();
            }
        }
    }
}