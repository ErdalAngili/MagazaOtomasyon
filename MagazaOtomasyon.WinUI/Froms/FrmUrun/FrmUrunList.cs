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
using MagazaOtomasyon.DataAccess.Concrete.EntityFramework;
using MagazaOtomasyon.Entities.Concrete;

namespace MagazaOtomasyon.WinUI.Forms.FrmUrun
{
    public partial class FrmUrunList : DevExpress.XtraEditors.XtraForm
    {
        public FrmUrunList()
        {
            InitializeComponent();
            _urunService = InstanceFactory.GetInstance<IUrunService>();
        }
        private IUrunService _urunService;
        FrmUrunYeni urunYeni;
        public void yenile()
        {
            gridControl1.DataSource = _urunService.GetAll();
        }
        private void barbtnYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (urunYeni==null||urunYeni.IsDisposed)
            {
                urunYeni = new FrmUrunYeni();
                urunYeni.ShowDialog();
            }
        }

        private void FrmUrunList_Load(object sender, EventArgs e)
        {
            yenile();
        }

        private void barYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            yenile();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textAra.Text))
            {
                gridControl1.DataSource = _urunService.GetUrunAd(textAra.Text);
            }
            else
            {
                MessageBox.Show("Arama Alanı Boş Bırakıldı");
            }
                
        }

        private void barDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunDuzenle frmUrunDuzenle = new FrmUrunDuzenle();
            frmUrunDuzenle.urunıd = int.Parse(gridView1.GetFocusedRowCellValue("UrunId").ToString());
            frmUrunDuzenle.urunad = gridView1.GetFocusedRowCellValue("UrunAd").ToString();
            frmUrunDuzenle.marka = gridView1.GetFocusedRowCellValue("Marka").ToString();
            frmUrunDuzenle.model = gridView1.GetFocusedRowCellValue("Model").ToString();
            frmUrunDuzenle.yil = int.Parse(gridView1.GetFocusedRowCellValue("Yil").ToString());
            frmUrunDuzenle.adet = int.Parse(gridView1.GetFocusedRowCellValue("Adet").ToString());
            frmUrunDuzenle.maliyet = decimal.Parse(gridView1.GetFocusedRowCellValue("Maliyet").ToString());
            frmUrunDuzenle.satisfiyati = decimal.Parse(gridView1.GetFocusedRowCellValue("SatisFiyat").ToString());
            frmUrunDuzenle.detay = gridView1.GetFocusedRowCellValue("Detay").ToString();
            frmUrunDuzenle.ShowDialog();
        }

        private void barSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Ürünü Silmek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _urunService.Delete(new Urun
                {
                    UrunId = int.Parse(gridView1.GetFocusedRowCellValue("UrunId").ToString())
                });
                yenile();
            }
            else
            {
                MessageBox.Show("Ürün Silinmedi ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void barCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void textAra_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textAra.Text))
            {
                yenile();
            }
        }
    }
}