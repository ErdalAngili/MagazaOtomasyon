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

namespace MagazaOtomasyon.WinUI.Froms.FrmPersonel
{
    public partial class FrmPersonelList : DevExpress.XtraEditors.XtraForm
    {
        public FrmPersonelList()
        {
            InitializeComponent();
            _personelService = InstanceFactory.GetInstance<IPersonelService>();
        }
        FrmPersonelYeni frmPersonelYeni;
        IPersonelService _personelService;
        private void barbtnYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPersonelYeni == null || frmPersonelYeni.IsDisposed)
            {
                frmPersonelYeni = new FrmPersonelYeni();
                frmPersonelYeni.ShowDialog();
            }
        }
        public void Listele()
        {
            gridControl1.DataSource = _personelService.GetAll();
        }
        private void FrmPersonelList_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void barYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Listele();
        }

        private void barDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonelDuzenle duzenle = new FrmPersonelDuzenle();
            duzenle.personelId = int.Parse(gridView1.GetFocusedRowCellValue("PersonelId").ToString());
            duzenle.Ad = gridView1.GetFocusedRowCellValue("Ad").ToString();
            duzenle.Soyad = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            duzenle.TCKimlikNo = gridView1.GetFocusedRowCellValue("Tc").ToString();
            duzenle.Telefon1 = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            duzenle.Gorev = gridView1.GetFocusedRowCellValue("Gorev").ToString();
            duzenle.Mail = gridView1.GetFocusedRowCellValue("Mail").ToString();
            duzenle.Il = gridView1.GetFocusedRowCellValue("Il").ToString();
            duzenle.Ilce = gridView1.GetFocusedRowCellValue("Ilce").ToString();
            duzenle.Ilce = gridView1.GetFocusedRowCellValue("Adres").ToString();
            duzenle.ShowDialog();
        }

        private void barSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Personel Bilgilerini Silmek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _personelService.Delete(new Personel
                {
                    PersonelId = int.Parse(gridView1.GetFocusedRowCellValue("PersonelId").ToString())
                });
                MessageBox.Show("Personel Bilgileri Silindi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else
            {
                MessageBox.Show("Personel Bilgileri Silinmedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                gridControl1.DataSource = _personelService.GetPersonelAd(textAra.Text);
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
                Listele();
            }
        }
    }
}