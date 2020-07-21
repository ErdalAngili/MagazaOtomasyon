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
using MagazaOtomasyon.Business.Abstract;
using MagazaOtomasyon.Business.DependencyResolvers.Ninject;
using MagazaOtomasyon.Entities.Concrete;

namespace MagazaOtomasyon.WinUI.Froms.FrmFirmalar
{
    public partial class FrmFirmaList : DevExpress.XtraEditors.XtraForm
    {
        public FrmFirmaList()
        {
            InitializeComponent();
            _firmaService = InstanceFactory.GetInstance<IFirmaService>();
        }
        IFirmaService _firmaService;
        FrmFirmaYeni frmFirmaYeni;
        private void barbtnYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmFirmaYeni == null || frmFirmaYeni.IsDisposed)
            {
                frmFirmaYeni = new FrmFirmaYeni();
                frmFirmaYeni.ShowDialog();
            }
        }
        public void listele()
        {
            gridControl1.DataSource = _firmaService.GetAll();
        }
        private void FrmFirmaList_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void barYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            listele();
        }
        private void barDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFirmaDuzenle frmFirmaDuzenle = new FrmFirmaDuzenle();
            frmFirmaDuzenle.firmaId = int.Parse(gridView1.GetFocusedRowCellValue("FirmaId").ToString());
            frmFirmaDuzenle.firmaAd = gridView1.GetFocusedRowCellValue("FirmaAd").ToString();
            frmFirmaDuzenle.YetkiliAdSoyad = gridView1.GetFocusedRowCellValue("YetkiliAdSoyad").ToString();
            frmFirmaDuzenle.YetkiliStatu = gridView1.GetFocusedRowCellValue("YetkiliStatu").ToString();
            frmFirmaDuzenle.Sektor = gridView1.GetFocusedRowCellValue("Sektor").ToString();
            frmFirmaDuzenle.Telefon1 = gridView1.GetFocusedRowCellValue("Telefon1").ToString();
            frmFirmaDuzenle.Telefon2 = gridView1.GetFocusedRowCellValue("Telefon2").ToString();
            frmFirmaDuzenle.Mail = gridView1.GetFocusedRowCellValue("Mail").ToString();
            frmFirmaDuzenle.Fax = gridView1.GetFocusedRowCellValue("Fax").ToString();
            frmFirmaDuzenle.Il = gridView1.GetFocusedRowCellValue("Il").ToString();
            frmFirmaDuzenle.Ilce = gridView1.GetFocusedRowCellValue("Ilce").ToString();
            frmFirmaDuzenle.VergiDairesi = gridView1.GetFocusedRowCellValue("VergiDaire").ToString();
            frmFirmaDuzenle.Adres = gridView1.GetFocusedRowCellValue("Adres").ToString();
            frmFirmaDuzenle.OzelKod1 = gridView1.GetFocusedRowCellValue("OzelKod1").ToString();
            frmFirmaDuzenle.ozelKod2 = gridView1.GetFocusedRowCellValue("OzelKod2").ToString();
            frmFirmaDuzenle.ShowDialog();
        }

        private void barSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Firma Bilgilerini Silmek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _firmaService.Delete(new Firma
                {
                    FirmaId = int.Parse(gridView1.GetFocusedRowCellValue("FirmaId").ToString())
                });
                MessageBox.Show("Firma Bilgileri Silindi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                MessageBox.Show("Firma Bilgileri Silinmedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void barCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textAra.Text))
            {
                gridControl1.DataSource = _firmaService.GetUrunAd(textAra.Text);
            }
            else
            {
                MessageBox.Show("Arama Alanı Boş Bırakıldı");
            }
        }

        private void textAra_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textAra.Text))
            {
                listele();
            }
        }
    }
}