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

namespace MagazaOtomasyon.WinUI.Froms.FrmMusteri
{
    public partial class FrmMusteriList : DevExpress.XtraEditors.XtraForm
    {
        public FrmMusteriList()
        {
            InitializeComponent();
            _musteriService = InstanceFactory.GetInstance<IMusteriService>();
        }
        IMusteriService _musteriService;
        FrmMusteriYeni MusteriYeni;
        public void listele()
        {
            gridControl1.DataSource = _musteriService.GetAll();
        }
        private void barbtnYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MusteriYeni == null || MusteriYeni.IsDisposed)
            {
                MusteriYeni = new FrmMusteriYeni();
                MusteriYeni.ShowDialog();
            }
        }

        private void barYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            listele();
        }

        private void FrmMusteriList_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textAra.Text))
            {
                gridControl1.DataSource = _musteriService.GetUrunAd(textAra.Text);
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

        private void barDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMusteriDuzenle frmMusteriDuzenle = new FrmMusteriDuzenle();
            frmMusteriDuzenle.MusteriId = int.Parse(gridView1.GetFocusedRowCellValue("MusteriId").ToString());
            frmMusteriDuzenle.Ad = gridView1.GetFocusedRowCellValue("Ad").ToString();
            frmMusteriDuzenle.Soyad = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            frmMusteriDuzenle.TCKimlikNo = gridView1.GetFocusedRowCellValue("Tc").ToString();
            frmMusteriDuzenle.Telefon1 = gridView1.GetFocusedRowCellValue("Telefon1").ToString();
            frmMusteriDuzenle.Telefon2 = gridView1.GetFocusedRowCellValue("Telefon2").ToString();
            frmMusteriDuzenle.Mail = gridView1.GetFocusedRowCellValue("Mail").ToString();
            frmMusteriDuzenle.Il = gridView1.GetFocusedRowCellValue("Il").ToString();
            frmMusteriDuzenle.Ilce = gridView1.GetFocusedRowCellValue("Ilce").ToString();
            frmMusteriDuzenle.Adres = gridView1.GetFocusedRowCellValue("Adres").ToString();
            frmMusteriDuzenle.VergiDairesi = gridView1.GetFocusedRowCellValue("VergiDaire").ToString();
            frmMusteriDuzenle.ShowDialog();
        }

        private void barSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Müşteri Bilgilerini Silmek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _musteriService.Delete(new Musteri
                {
                    MusteriId = int.Parse(gridView1.GetFocusedRowCellValue("MusteriId").ToString())
                });
                MessageBox.Show("Müşteri Bilgileri Silindi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                MessageBox.Show("Müşteri Bilgileri Silinmedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void barCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}