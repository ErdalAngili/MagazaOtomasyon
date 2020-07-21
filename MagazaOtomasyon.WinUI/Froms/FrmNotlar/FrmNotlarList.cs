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

namespace MagazaOtomasyon.WinUI.Froms.FrmNotlar
{
    public partial class FrmNotlarList : DevExpress.XtraEditors.XtraForm
    {
        public FrmNotlarList()
        {
            InitializeComponent();
            _notlarService = InstanceFactory.GetInstance<INotlarService>();
        }
        INotlarService _notlarService;
        private void barbtnYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNotlarYeni frmNotlarYeni = new FrmNotlarYeni();
            frmNotlarYeni.ShowDialog();
        }
        public void Listele()
        {
            gridControl1.DataSource = _notlarService.GetAll();
        }
        private void barYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Listele();
        }

        private void barCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textAra.Text))
            {
                gridControl1.DataSource = _notlarService.NotHitap(textAra.Text);
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

        private void barSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Not Bilgilerini Silmek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _notlarService.Delete(new Not
                {
                    NotId = int.Parse(gridView1.GetFocusedRowCellValue("NotId").ToString())
                });
                MessageBox.Show("Not Bilgileri Silindi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else
            {
                MessageBox.Show("Not Bilgileri Silinmedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void barDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNotlarDuzenle frmNotlarDuzenle = new FrmNotlarDuzenle();
            frmNotlarDuzenle.notId = int.Parse(gridView1.GetFocusedRowCellValue("NotId").ToString());
            frmNotlarDuzenle.baslik = gridView1.GetFocusedRowCellValue("Baslik").ToString();
            frmNotlarDuzenle.olusturan = gridView1.GetFocusedRowCellValue("Olusturan").ToString();
            frmNotlarDuzenle.hitap = gridView1.GetFocusedRowCellValue("Hitap").ToString();
            frmNotlarDuzenle.detay = gridView1.GetFocusedRowCellValue("Detay").ToString();
            frmNotlarDuzenle.tarih = gridView1.GetFocusedRowCellValue("Tarih").ToString();
            frmNotlarDuzenle.saat = gridView1.GetFocusedRowCellValue("Saat").ToString();
            frmNotlarDuzenle.ShowDialog();
        }

        private void FrmNotlarList_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}