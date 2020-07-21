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
using MagazaOtomasyon.DataAccess.Abstract;
using MagazaOtomasyon.DataAccess.Concrete.EntityFramework;
using MagazaOtomasyon.Business.DependencyResolvers.Ninject;
using MagazaOtomasyon.Business.Abstract;
using MagazaOtomasyon.Entities.Concrete;

namespace MagazaOtomasyon.WinUI.Froms.FrmBanka
{
    public partial class FrmBankaList : DevExpress.XtraEditors.XtraForm
    {
        public FrmBankaList()
        {
            InitializeComponent();
            _efBankadal = InstanceFactory.GetInstance<EfBankaDal>();
            _bankaService = InstanceFactory.GetInstance<IBankaService>();
        }

        EfBankaDal _efBankadal;
        IBankaService _bankaService;
        public void Listele()
        {
            gridControl1.DataSource = _efBankadal.GetBankaDetails();
        }
        private void FrmBankaList_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void barYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Listele();
        }

        private void barCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        FrmBankaYeni FrmBankaYeni;
        private void barbtnYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FrmBankaYeni == null || FrmBankaYeni.IsDisposed)
            {
                FrmBankaYeni = new FrmBankaYeni();
                FrmBankaYeni.ShowDialog();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textAra.Text))
            {
                gridControl1.DataSource = _bankaService.GetYetkiliAd(textAra.Text);
            }
            else
            {
                MessageBox.Show("Arama Alanı Boş Bırakıldı");
            }
        }

        private void barDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBankaDuzenle frmBankaDuzenle = new FrmBankaDuzenle();
            frmBankaDuzenle.firmaAd = gridView1.GetFocusedRowCellValue("FirmaAd").ToString();
            frmBankaDuzenle.bankaAd = gridView1.GetFocusedRowCellValue("BankaAdı").ToString();
            frmBankaDuzenle.bankaId = int.Parse(gridView1.GetFocusedRowCellValue("BankaId").ToString());
            frmBankaDuzenle.il = gridView1.GetFocusedRowCellValue("Il").ToString();
            frmBankaDuzenle.ilce = gridView1.GetFocusedRowCellValue("Ilce").ToString();
            frmBankaDuzenle.yetkili = gridView1.GetFocusedRowCellValue("Yetkili").ToString();
            frmBankaDuzenle.iban = gridView1.GetFocusedRowCellValue("Iban").ToString();
            frmBankaDuzenle.sube = gridView1.GetFocusedRowCellValue("Sube").ToString();
            frmBankaDuzenle.telefon = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            frmBankaDuzenle.hesapno = gridView1.GetFocusedRowCellValue("HesapNo").ToString();
            frmBankaDuzenle.tarih = gridView1.GetFocusedRowCellValue("Tarih").ToString();
            frmBankaDuzenle.hesapturu = gridView1.GetFocusedRowCellValue("HesapTuru").ToString();
            frmBankaDuzenle.ComboFirmaListele();
            frmBankaDuzenle.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Banka Bilgilerini Silmek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _bankaService.Delete(new Banka
                {
                    BankaId = int.Parse(gridView1.GetFocusedRowCellValue("BankaId").ToString())
                });
                MessageBox.Show("Banka Bilgileri Silindi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else
            {
                MessageBox.Show("Banka Bilgileri Silinmedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}